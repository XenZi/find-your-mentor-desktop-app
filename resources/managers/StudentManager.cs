using SR38_2021_POP2022.resources.models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR38_2021_POP2022.resources.managers
{
    class StudentManager
    {
        private static StudentManager instance;
        private ObservableCollection<Student> allStudents = new ObservableCollection<Student>();
        public static readonly string FILE_PATH = "C:\\Users\\rilak\\source\\repos\\SR38-2021-POP2022\\SR38-2021-POP2022\\data\\txt\\students.txt";

        public ObservableCollection<Student> AllStudents { get => allStudents; set => allStudents = value; }

        private StudentManager() { }

        public static StudentManager GetInstance()
        {
            if (instance == null) instance = new StudentManager();
            return instance;
        }

        public Student GetStudentByIdentityNumber(string number)
        {
            try
            {
                Student student = allStudents.ToList().Find(x => x.PersonalIdentityNumber == number);
                return student;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
