using SR38_2021_POP2022.utilities.exceptions;
using SR38_2021_POP2022.resources.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace SR38_2021_POP2022.resources.managers
{
    class SchoolManager
    {
        private static SchoolManager instance;
        private ObservableCollection<School> allSchools = new ObservableCollection<School>();
        public static readonly string FILE_PATH = "C:\\Users\\rilak\\source\\repos\\SR38-2021-POP2022\\SR38-2021-POP2022\\data\\txt\\schools.txt";

        public ObservableCollection<School> AllSchools { get => allSchools; set => allSchools = value; }

        private SchoolManager() { }

        public static SchoolManager GetInstance()
        {
            if (instance == null) instance = new SchoolManager();
            return instance;
        }

        public School GetSchoolById(int id)
        {
            
            School school = allSchools.ToList().Find(x => x.Id == id);
            if (school == null)
            {
                throw new SchoolNotFoundException("School that you've been searching for isn't found!");
            }
            return school;
        }

        public School GetSchoolByName(string name)
        {

            School school = allSchools.ToList().Find(x => x.Name == name);
            if (school == null)
            {
                throw new SchoolNotFoundException("School that you've been searching for isn't found!");
            }
            return school;
        }

        public ObservableCollection<School> GetSchoolByLanguage(string languageName)
        {
            ObservableCollection<School> foundSchools = new ObservableCollection<School>();

            allSchools.ToList().ForEach(school =>
            {
                if (school.AllLanguages.ToList().Exists(x => x.LanguageName == languageName))
                {
                    foundSchools.Add(school);
                }
            });

            return foundSchools;
        }

    }
}
