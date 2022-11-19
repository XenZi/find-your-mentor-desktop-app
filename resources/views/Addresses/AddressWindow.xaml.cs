using SR38_2021_POP2022.resources.enums;
using SR38_2021_POP2022.resources.models;
using SR38_2021_POP2022.resources.services;
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

namespace SR38_2021_POP2022.resources.views.Addresses
{
    /// <summary>
    /// Interaction logic for AddressWindow.xaml
    /// </summary>
    public partial class AddressWindow : Window
    {
        private AddressService service = new AddressService();
        private ICollectionView view;
        public AddressWindow()
        {
            InitializeComponent();
            view = CollectionViewSource.GetDefaultView(service.GetAllAddresses());
            InitializeData();
        }

        private void InitializeData()
        {
            dataAddresses.ItemsSource = view;
        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            CreateUpdateAddressWindow cuaw = new CreateUpdateAddressWindow(EWindowStatus.CREATE);
            cuaw.Show();
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            if (dataAddresses.SelectedItems.Count == 0)
            {
                MessageBox.Show("Something must be selected!");
                return;
            }
            Address address = (Address)dataAddresses.SelectedItem;
            CreateUpdateAddressWindow cuaw = new CreateUpdateAddressWindow(EWindowStatus.UPDATE, address);
            cuaw.ShowDialog();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (dataAddresses.SelectedItems.Count == 0)
            {
                MessageBox.Show("Something must be selected!");
                return;
            }
            Address address = (Address)dataAddresses.SelectedItem;
            service.DeleteAddress(address.Id);
            dataAddresses.ItemsSource = service.GetAllAddresses();
        }
    }
}
