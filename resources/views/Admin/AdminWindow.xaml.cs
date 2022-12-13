﻿using SR38_2021_POP2022.resources.enums;
using SR38_2021_POP2022.resources.models;
using SR38_2021_POP2022.resources.services;
using SR38_2021_POP2022.resources.views.Addresses;
using SR38_2021_POP2022.resources.views.Languages;
using SR38_2021_POP2022.resources.views.Schools;
using SR38_2021_POP2022.resources.views.Sessions;
using SR38_2021_POP2022.resources.views.Students;
using SR38_2021_POP2022.resources.views.Teachers;
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

namespace SR38_2021_POP2022.resources.views.Admin
{
    /// <summary>
    /// Interaction logic for AdminView.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        private StudentService studentService;
        private TeacherService teacherService;
        private ICollectionView view1;
        private ICollectionView view2;
        public AdminWindow()
        {
            InitializeComponent();
            studentService = new StudentService();
            teacherService = new TeacherService();
            InitializeData();
        }

        private void InitializeData()
        {
            view1 = CollectionViewSource.GetDefaultView(studentService.GetAllStudents());
            view2 = CollectionViewSource.GetDefaultView(teacherService.GetAllTeachers());
            dataStudents.ItemsSource = view1;
            dataTeachers.ItemsSource = view2;
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

        private void btnCreateStudent_Click(object sender, RoutedEventArgs e)
        {
            CreateUpdateStudentWindow cusw = new CreateUpdateStudentWindow(EWindowStatus.CREATE);
            cusw.ShowDialog();
            dataStudents.ItemsSource = studentService.GetAllStudents();
        }

        private void btnUpdateStudent_Click(object sender, RoutedEventArgs e)
        {
            if (dataStudents.SelectedItems.Count == 0)
            {
                MessageBox.Show("Something must be selected!");
                return;
            }

            Student student = (Student) dataStudents.SelectedItem;
            CreateUpdateStudentWindow cusw = new CreateUpdateStudentWindow(EWindowStatus.UPDATE, student);
            cusw.Show();
        }

        private void btnDeleteStudent_Click(object sender, RoutedEventArgs e)
        {
            if (dataStudents.SelectedItems.Count == 0)
            {
                MessageBox.Show("Something must be selected!");
                return;
            }
            Student student = (Student)dataStudents.SelectedItem;
            studentService.DeleteStudent(student.PersonalIdentityNumber);
            dataStudents.ItemsSource = studentService.GetAllStudents();
        }

        private void btnCreateTeacher_Click(object sender, RoutedEventArgs e)
        {
            CreateUpdateTeacher cutw = new CreateUpdateTeacher(EWindowStatus.CREATE);
            cutw.ShowDialog();
            dataTeachers.ItemsSource = teacherService.GetAllTeachers();
        }

        private void btnUpdateTeacher_Click(object sender, RoutedEventArgs e)
        {
            if (dataTeachers.SelectedItems.Count == 0)
            {
                MessageBox.Show("Something must be selected!");
                return;
            }
            Teacher teacher = (Teacher)dataTeachers.SelectedItem;
            CreateUpdateTeacher cutw = new CreateUpdateTeacher(EWindowStatus.UPDATE, teacher);
            cutw.ShowDialog();
        }

        private void btnDeleteTeacher_Click(object sender, RoutedEventArgs e)
        {
            if (dataTeachers.SelectedItems.Count == 0)
            {
                MessageBox.Show("Something must be selected!");
                return;
            }
            Teacher teacher = (Teacher)dataTeachers.SelectedItem;
            teacherService.DeleteTeacher(teacher.PersonalIdentityNumber);
            InitializeData();
        }
    }
}
