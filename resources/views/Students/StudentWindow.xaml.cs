﻿using SR38_2021_POP2022.resources.models;
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

namespace SR38_2021_POP2022.resources.views.Students
{
    /// <summary>
    /// Interaction logic for StudentWidnow.xaml
    /// </summary>
    public partial class StudentWindow : Window
    {
        private SessionService sessionService;
        private TeacherService teacherService;
        private StudentService studentService;
        private Student student;
        public StudentWindow(Student student)
        {
            InitializeComponent();
            this.student = student;
            this.sessionService = new SessionService();
            this.teacherService = new TeacherService();
            this.studentService = new StudentService();
            InitializeData();
        }

        private void InitializeData()
        {
            dataAvailableClasses.ItemsSource = sessionService.GetAllAvailableSessions();
            dataReservedClasses.ItemsSource = sessionService.GetAllReservedSessionsByStudentID(student.PersonalIdentityNumber);
            cmbSelectTeacher.ItemsSource = teacherService.GetAllTeachers();
        }

        private void cmbSelectTeacher_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Teacher teacher = (Teacher)cmbSelectTeacher.SelectedItem;
            dataAvailableClasses.ItemsSource = sessionService.GetAllAvailableSessionByTeacherID(teacher.PersonalIdentityNumber);
        }

        private void btnReserve_Click(object sender, RoutedEventArgs e)
        {
            Session clickedSession = (Session) dataAvailableClasses.SelectedItem;
            sessionService.MakeSessionReserved(clickedSession, student);
            InitializeData();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Session clickedSession = (Session)dataReservedClasses.SelectedItem;
            sessionService.MakeSessionAvailable(clickedSession);
            InitializeData();
        }

        private void btnViewPersonalInfo_Click(object sender, RoutedEventArgs e)
        {
            ViewStudentPersonalnfoWindow vspiw = new ViewStudentPersonalnfoWindow(student);
            vspiw.Show();
        }
    }
}
