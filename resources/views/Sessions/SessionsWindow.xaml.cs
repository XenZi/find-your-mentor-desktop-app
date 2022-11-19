﻿using SR38_2021_POP2022.resources.services;
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

namespace SR38_2021_POP2022.resources.views.Sessions
{
    /// <summary>
    /// Interaction logic for SessionsWindow.xaml
    /// </summary>
    public partial class SessionsWindow : Window
    {
        private SessionService service;
        private ICollectionView view;
        public SessionsWindow()
        {
            InitializeComponent();
            service = new SessionService();
            view = CollectionViewSource.GetDefaultView(service.GetAllSessions());
            dataSessions.ItemsSource = view;
            dataSessions.IsSynchronizedWithCurrentItem = true;
            dataSessions.ColumnWidth = new DataGridLength(1, DataGridLengthUnitType.Star);
        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            CreateUpdateSession cus = new CreateUpdateSession(enums.EWindowStatus.CREATE);
            cus.Show();
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
