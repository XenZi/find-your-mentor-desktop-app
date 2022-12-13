﻿using SR38_2021_POP2022.resources.enums;
using SR38_2021_POP2022.resources.models;
using SR38_2021_POP2022.resources.services;
using SR38_2021_POP2022.resources.views.Sessions;
using SR38_2021_POP2022.resources.views.Students;
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

namespace SR38_2021_POP2022.resources.views.Teachers
{
    /// <summary>
    /// Interaction logic for TeacherWindow.xaml
    /// </summary>
    public partial class TeacherWindow : Window
    {
        private Teacher teacher;
        private SessionService sessionService;
        private StudentService studentService;
        private ICollectionView view;

        public TeacherWindow(Teacher loggedTeacher)
        {
            InitializeComponent();
            this.teacher = loggedTeacher;
            sessionService = new SessionService();
            studentService = new StudentService();
            view = CollectionViewSource.GetDefaultView(sessionService.GetAllSessions());
            InitializeData();
        }

        private void InitializeData()
        {
            dataSessions.ItemsSource = view;
        }

        private void sessionDate_ValueChanged(object sender, EventArgs e)
        {
            dataSessions.ItemsSource = sessionService.GetSessionsBasedByTeacherIDAndDate(teacher.PersonalIdentityNumber, (DateTime)sessionDate.SelectedDate);
        }

        private void btnViewStudent_Click(object sender, RoutedEventArgs e)
        {
            Session session = (Session) dataSessions.SelectedItem;
            if (dataSessions.SelectedItems.Count == 0 || session.Status.Equals(EClassStatus.AVAILABLE))
            {
                MessageBox.Show("Something must be selected, or selected item must be reserved!");
                return;
            }
            Student student = studentService.FindBySessionID(session.Id);
            ViewStudentPersonalnfoWindow vspiw = new ViewStudentPersonalnfoWindow(student);
            vspiw.Show();
        }

        private void btnDeleteSession_Click(object sender, RoutedEventArgs e)
        {
            Session session = (Session)dataSessions.SelectedItem;
            if (dataSessions.SelectedItems.Count == 0 || session.Status.Equals(EClassStatus.RESERVED))
            {
                MessageBox.Show("You need to select something, or if you've selected something, you can delete only available sessions!");
                return;
            }
            sessionService.Delete(session.Id);
            dataSessions.ItemsSource = sessionService.GetAllSessions();
            view.Refresh();
        }

        private void btnCreateSession_Click(object sender, RoutedEventArgs e)
        {
            CreateUpdateSession cus = new CreateUpdateSession(EWindowStatus.CREATE);
            cus.Show();
            dataSessions.ItemsSource = sessionService.GetAllSessions();
        }
    }
}
