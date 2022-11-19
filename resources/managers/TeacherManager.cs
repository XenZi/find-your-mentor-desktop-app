using SR38_2021_POP2022.resources.models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SR38_2021_POP2022.resources.managers
{
    class TeacherManager { 
        private static TeacherManager instance;
        private ObservableCollection<Teacher> allTeachers = new ObservableCollection<Teacher>();
        public static readonly string FILE_PATH = "C:\\Users\\rilak\\source\\repos\\SR38-2021-POP2022\\SR38-2021-POP2022\\data\\txt\\teachers.txt";

        public ObservableCollection<Teacher> AllTeachers { get => allTeachers; set => allTeachers = value; }

        private TeacherManager() { }

        public static TeacherManager GetInstance()
        {
            if (instance == null) instance = new TeacherManager();
            return instance;
        }

        public Teacher GetTeacherByIdentityNumber(string identityNumber)
        {
            try
            {
                Teacher teacher = allTeachers.ToList().Find(x => x.PersonalIdentityNumber == identityNumber);
                return teacher;
            }
            catch(NullReferenceException ex) 
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Teacher> GetTeachersBasedBySchoolID(int schoolID)
        {
            List<Teacher> list = new List<Teacher>();
            
            return list;
        }
    }
}
