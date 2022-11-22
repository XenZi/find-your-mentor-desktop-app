using SR38_2021_POP2022.resources.enums;
using SR38_2021_POP2022.resources.models;
using SR38_2021_POP2022.resources.services;
using SR38_2021_POP2022.resources.views.Addresses;
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

namespace SR38_2021_POP2022.resources.views.Languages
{
    /// <summary>
    /// Interaction logic for LanguagesWindow.xaml
    /// </summary>
    public partial class LanguagesWindow : Window
    {
        private LanguageService service = new LanguageService();
        private ICollectionView view;
        public LanguagesWindow()
        {
            InitializeComponent();
            InitializeData();
            view = CollectionViewSource.GetDefaultView(service.GetAllLanguages());
        }

        private void InitializeData()
        {
            view = CollectionViewSource.GetDefaultView(service.GetAllLanguages());
            dataLanguages.ItemsSource = view;
        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            CreateUpdateLanguageWindow culw = new CreateUpdateLanguageWindow(EWindowStatus.CREATE);
            if (culw.ShowDialog() == true)
            {
                view.Refresh();
            }
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            if (dataLanguages.SelectedItems.Count == 0)
            {
                MessageBox.Show("Something must be selected!");
                return;
            }
            Language language = (Language)dataLanguages.SelectedItem; 
            CreateUpdateLanguageWindow culw = new CreateUpdateLanguageWindow(EWindowStatus.UPDATE, language);
            culw.ShowDialog();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (dataLanguages.SelectedItems.Count == 0)
            {
                MessageBox.Show("Something must be selected!");
                return;
            }
            Language language = (Language)dataLanguages.SelectedItem;
            service.DeleteLanguage(language.Id);
            dataLanguages.ItemsSource = service.GetAllLanguages();
        }
    }
}
