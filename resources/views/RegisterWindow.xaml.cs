using SR38_2021_POP2022.resources.enums;
using SR38_2021_POP2022.resources.models;
using SR38_2021_POP2022.resources.services;
using SR38_2021_POP2022.utilities;
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
    /// Interaction logic for RegisterWindow.xaml
    /// </summary>
    public partial class RegisterWindow : Window
    {
        private StudentService studentService;
        public RegisterWindow()
        {
            InitializeComponent();
            studentService = new StudentService();
            this.DataContext = new Student();
        }

        private bool IsValid()
        {
            return !Validation.GetHasError(txtEmail) && !Validation.GetHasError(txtPersonalIdentityNumber);
        }
        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            if (CheckForPersonalIdentityDuplicates.CheckForDuplicates(txtPersonalIdentityNumber.Text))
            {
                MessageBox.Show($"Personal identity already exists, use your own!");
                return;
            }
            if (IsValid())
            {
                studentService.CreateStudent(txtFirstName.Text, txtLastName.Text, txtPersonalIdentityNumber.Text, txtEmail.Text, txtPassword.Password, EUserType.Student, (EGender)Enum.Parse(typeof(EGender), comboGender.Text), txtStreetAddress.Text, int.Parse(txtStreetNumber.Text), txtCity.Text, txtCountry.Text);
                MessageBox.Show("You have been successfully logged in! Redirecting you to the login window.");
                LoginWindow lw = new LoginWindow();
                lw.Show();
                this.Close();
                return;
            }
            MessageBox.Show("Check up on your errors! Something is wrong!");
        }
    }
}
