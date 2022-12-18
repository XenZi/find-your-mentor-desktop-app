using SR38_2021_POP2022.resources.enums;
using SR38_2021_POP2022.resources.models;
using SR38_2021_POP2022.resources.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
    /// Interaction logic for CreateUpdateSession.xaml
    /// </summary>
    public partial class CreateUpdateSession : Window
    {
        private EWindowStatus status;
        private Session session;
        private SessionService service;
        private TeacherService teacherService;
        private Teacher teacherCreating;
        public CreateUpdateSession(EWindowStatus status, Session session = null, Teacher teacherCreating = null)
        {
            InitializeComponent();
            this.status = status;
            this.session = session;
            this.teacherCreating = teacherCreating;
            InitializeData();
            datePicker.DisplayDateStart = DateTime.Today;
            MakeWindowChangesBasedByStatus();
            InitializeTextBoxValues();
        }

        private void InitializeData()
        {
            service = new SessionService();
            teacherService = new TeacherService();
            cmbTeacher.ItemsSource = teacherService.GetAllTeachers().ToList();
        }
        private void MakeWindowChangesBasedByStatus()
        {
            if (status.Equals(EWindowStatus.CREATE))
            {
                this.Title = "Create new session";
                btnSubmit.Content = "Create";
            }
            else
            {
                this.Title = "Update current session";
                btnSubmit.Content = "Update";
            }

            if (teacherCreating != null)
            {
                cmbTeacher.SelectedItem = teacherCreating;
                cmbTeacher.IsEnabled = false;
            }
        }

        private void InitializeTextBoxValues()
        {
            if (session == null)
            {
                return;
            }
            txtClassLength.Text = session.ClassLength.ToString();
            txtStartingTime.Text = session.StartingTime;
            cmbTeacher.SelectedItem = session.Teacher;
            datePicker.SelectedDate = session.ReservedDate;
        }
        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            if (status.Equals(EWindowStatus.CREATE))
            {
                CreateNewSession();
            }
            else
            {
                UpdateSession();
            }
            this.Close();
        }

        private void CreateNewSession()
        {
            Teacher teacher = (Teacher) cmbTeacher.SelectedItem;
            service.Create(teacher, (DateTime) datePicker.SelectedDate, txtStartingTime.Text, int.Parse(txtClassLength.Text), EClassStatus.AVAILABLE);
        }

        private void UpdateSession()
        {
            Teacher teacher = (Teacher)cmbTeacher.SelectedItem;
            service.Update(session.Id, teacher, (DateTime)datePicker.SelectedDate, txtStartingTime.Text, int.Parse(txtClassLength.Text), EClassStatus.AVAILABLE);
        }
    }
}
