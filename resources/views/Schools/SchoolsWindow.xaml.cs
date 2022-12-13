using SR38_2021_POP2022.resources.enums;
using SR38_2021_POP2022.resources.models;
using SR38_2021_POP2022.resources.services;
using SR38_2021_POP2022.resources.views.Languages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace SR38_2021_POP2022.resources.views.Schools
{
    /// <summary>
    /// Interaction logic for SchoolsWindow.xaml
    /// </summary>
    public partial class SchoolsWindow : Window
    {
        private SchoolService service;
        private ICollectionView view;
        public SchoolsWindow()
        {
            InitializeComponent();
            service = new SchoolService();
            InitializeData();
        }

        private void InitializeData()
        {
            view = CollectionViewSource.GetDefaultView(service.GetAllSchools());
            dataSchool.ItemsSource = view;
            dataSchool.IsSynchronizedWithCurrentItem = true;

            dataSchool.ColumnWidth = new DataGridLength(1, DataGridLengthUnitType.Star);
        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            CreateUpdateSchoolWindow cusw = new CreateUpdateSchoolWindow(EWindowStatus.CREATE);
            if(cusw.ShowDialog() == true)
            {
                view.Refresh();
                dataSchool.ItemsSource = service.GetAllSchools();
            }
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            if (dataSchool.SelectedItems.Count == 0)
            {
                MessageBox.Show("Something must be selected!");
                return;
            }
            School school = (School) dataSchool.SelectedItem;
            CreateUpdateSchoolWindow culw = new CreateUpdateSchoolWindow(EWindowStatus.UPDATE, school);
            culw.ShowDialog();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (dataSchool.SelectedItems.Count == 0)
            {
                MessageBox.Show("Something must be selected!");
                return;
            }
            School school = (School)dataSchool.SelectedItem;
            service.Delete(school.Id);
            dataSchool.ItemsSource = service.GetAllSchools();
        }
    }
}
