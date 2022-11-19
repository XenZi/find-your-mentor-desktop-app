using SR38_2021_POP2022.resources.services;
using SR38_2021_POP2022.resources.views.Addresses;
using SR38_2021_POP2022.resources.views.Languages;
using SR38_2021_POP2022.resources.views.Schools;
using SR38_2021_POP2022.resources.views.Sessions;
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

namespace SR38_2021_POP2022.resources.views.Admin
{
    /// <summary>
    /// Interaction logic for AdminView.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        StudentService studentService;
        TeacherService teacherService;
        public AdminWindow()
        {
            InitializeComponent();
            studentService = new StudentService();
            teacherService = new TeacherService();
            InitializeData();
        }

        private void InitializeData()
        {
            dataStudents.ItemsSource = studentService.GetAllStudents();
            dataTeachers.ItemsSource = teacherService.GetAllTeachers();
        }

        private void btnAddress_Click(object sender, RoutedEventArgs e)
        {
            AddressWindow addressWindow = new AddressWindow();
            addressWindow.Show();
        }

        private void btnLanguages_Click(object sender, RoutedEventArgs e)
        {
            LanguagesWindow lw = new LanguagesWindow();
            lw.Show();
        }

        private void btnSchools_Click(object sender, RoutedEventArgs e)
        {
            SchoolsWindow sw = new SchoolsWindow();
            sw.Show();
        }

        private void btnSessions_Click(object sender, RoutedEventArgs e)
        {
            SessionsWindow sw = new SessionsWindow();
            sw.Show();
        }
    }
}
