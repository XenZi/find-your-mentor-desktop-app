using SR38_2021_POP2022.resources.enums;
using SR38_2021_POP2022.resources.models;
using SR38_2021_POP2022.resources.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SR38_2021_POP2022.resources.views.Students
{
    /// <summary>
    /// Interaction logic for ViewStudentPersonalnfoWindow.xaml
    /// </summary>
    public partial class ViewStudentPersonalnfoWindow : Window
    {
        private Student student;

        public ViewStudentPersonalnfoWindow(Student student)
        {
            InitializeComponent();
            this.student = student;
            comboGender.ItemsSource = Enum.GetNames(typeof(EGender));
            InitializeTextBoxValues();
        }

        private void InitializeTextBoxValues()
        {
            if (student == null)
            {
                return;
            }
            txtFirstName.Text = student.FirstName;
            txtLastName.Text = student.LastName;
            txtEmail.Text = student.Email;
            txtStreetAddress.Text = student.Address.Street;
            txtStreetNumber.Text = student.Address.Number.ToString();
            txtCity.Text = student.Address.City;
            txtCountry.Text = student.Address.Country;
            comboGender.SelectedIndex = (int) student.Gender;
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
