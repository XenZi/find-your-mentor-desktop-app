using SR38_2021_POP2022.resources.managers;
using SR38_2021_POP2022.resources.models;
using SR38_2021_POP2022.resources.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
    /// Interaction logic for GuestWindow.xaml
    /// </summary>
    public partial class GuestWindow : Window
    {
        public GuestWindow()
        {
            InitializeComponent();
            InitializeData();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void InitializeData()
        {
            dataSchools.ItemsSource = null;
            dataSchools.ItemsSource = SchoolManager.GetInstance().AllSchools;
        }

        private void btnSearchTeacher_Click(object sender, RoutedEventArgs e)
        {
            var selectedSchool = dataSchools.SelectedItem;
            if (selectedSchool == null)
            {
                MessageBox.Show("Oups! You need to select school in order to search for teachers in it");
                return;
            }

            School clickedSchool = (School)selectedSchool;
            SearchTeachersWindow stw = new SearchTeachersWindow(clickedSchool.Id);
            stw.Show();
            this.Hide();
        }

        private void btnGetBack_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow lw = new LoginWindow();
            lw.Show();
            this.Hide();
        }
    }
}
