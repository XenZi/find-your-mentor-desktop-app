using SR38_2021_POP2022.resources.managers;
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

namespace SR38_2021_POP2022.resources.views
{
    /// <summary>
    /// Interaction logic for SearchTeachersWindow.xaml
    /// </summary>
    public partial class SearchTeachersWindow : Window
    {
        private int schoolID;
        private TeacherService service;
        public SearchTeachersWindow(int schoolID)
        {
            InitializeComponent();
            this.schoolID = schoolID;
            service = new TeacherService();
            InitializeSchoolTeachers();
        }

        private void InitializeSchoolTeachers()
        {
            dataTeachers.ItemsSource = service.GetTeachersBasedBySchoolID(schoolID);
        }
    }
}
