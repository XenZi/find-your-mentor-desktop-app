﻿using SR38_2021_POP2022.resources.enums;
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

namespace SR38_2021_POP2022.resources.views.Addresses
{
    /// <summary>
    /// Interaction logic for CreateUpdateAddress.xaml
    /// </summary>
    public partial class CreateUpdateAddressWindow : Window
    {
        private EWindowStatus status;
        private Address address;
        private AddressService service;
        public CreateUpdateAddressWindow(EWindowStatus status, Address address = null)
        {
            InitializeComponent();
            this.status = status;
            this.address = address;
            service = new AddressService();
            MakeWindowChangesBasedByStatus();
            InitializeTextBoxValues();
        }

        private void MakeWindowChangesBasedByStatus()
        {
            if (status.Equals(EWindowStatus.CREATE))
            {
                this.Title = "Create new address";
                btnSubmit.Content = "Create";
            }
            else
            {
                this.Title = "Update current address";
                btnSubmit.Content = "Update";
            }
        }

        private void InitializeTextBoxValues()
        {
            if (address == null)
            {
                return;
            }
            txtCity.Text = address.City;
            txtCountry.Text = address.Country;
            txtNumber.Text = address.Number.ToString();
            txtStreet.Text = address.Street;
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            if (status.Equals(EWindowStatus.CREATE))
            {
                CreateNewAddress();
                this.DialogResult = true;
            }
            else
            {
                UpdateAddress();
            }
        }

        private void CreateNewAddress()
        {
            service.CreateAddress(txtStreet.Text, Int32.Parse(txtNumber.Text), txtCity.Text, txtCountry.Text);
        }

        private void UpdateAddress()
        {
            service.UpdateAddress(address.Id, txtStreet.Text, Int32.Parse(txtNumber.Text), txtCity.Text, txtCountry.Text);
        }
    }
}
