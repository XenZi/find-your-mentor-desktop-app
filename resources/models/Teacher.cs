using SR38_2021_POP2022.resources.enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR38_2021_POP2022.resources.models
{
    public class Teacher : User, INotifyPropertyChanged
    {
        private School workingSchool;
        private List<Language> teachingLanguages;
        private List<Session> sessions;
        public Teacher()
        {
        }

        public Teacher(string firstName, string lastName, string personalIdentityNumber, string email, string password, EUserType userType, EGender gender, Address address, bool active, School workingSchool, List<Language> teachingLanguages, List<Session> sessions) : base(firstName, lastName, personalIdentityNumber, email, password, userType, gender, active, address)
        {
            this.workingSchool = workingSchool;
            this.teachingLanguages = teachingLanguages;
            this.sessions = sessions;
        }

        public School WorkingSchool { get => workingSchool; set { workingSchool = value; OnPropertyChanged("workingSchool"); } }
        public List<Language> TeachingLanguages { get => teachingLanguages; set { teachingLanguages = value; OnPropertyChanged("workingSchool"); } }
        public List<Session> Sessions { get => sessions; set { sessions = value; OnPropertyChanged("workingSchool"); } }

        public new event PropertyChangedEventHandler PropertyChanged;

        protected new void OnPropertyChanged(String name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }

        public override string ToString()
        {
            return this.firstName + " " + this.lastName;
        }
    }
}
