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

namespace SR38_2021_POP2022.resources.views
{
    /// <summary>
    /// Interaction logic for ViewUpdatePersonalData.xaml
    /// </summary>
    public partial class ViewUpdatePersonalData : Window
    {
        private Teacher teacher;
        private TeacherService service;
        public ViewUpdatePersonalData(Teacher teacher)
        {
            InitializeComponent();
            this.teacher = teacher;
            this.service = new TeacherService();
            comboGender.ItemsSource = Enum.GetNames(typeof(EGender));
            InitializeTextBoxValues();
            this.DataContext = teacher;
        }

        private void InitializeTextBoxValues()
        {
            if (teacher == null)
            {
                return;
            }
            txtFirstName.Text = teacher.FirstName;
            txtLastName.Text = teacher.LastName;
            txtEmail.Text = teacher.Email;
            txtStreetAddress.Text = teacher.Address.Street;
            txtStreetNumber.Text = teacher.Address.Number.ToString();
            txtCity.Text = teacher.Address.City;
            txtPersonalIdentityNumber.Text = teacher.PersonalIdentityNumber;
            txtPersonalIdentityNumber.IsEnabled = false;
            txtCountry.Text = teacher.Address.Country;
            txtPassword.Password = teacher.Password;
            comboGender.SelectedItem = teacher.Gender;
            btnSubmit.Content = "Update personal info";
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            service.UpdateTeacher(txtFirstName.Text, txtLastName.Text, txtPersonalIdentityNumber.Text, txtEmail.Text, txtPassword.Password, EUserType.Teacher, (EGender) comboGender.SelectedItem, txtStreetAddress.Text, int.Parse(txtStreetNumber.Text), txtCity.Text, txtCountry.Text, true, teacher.WorkingSchool.Name, teacher.TeachingLanguages);
            this.Close();
        }
    }
}
