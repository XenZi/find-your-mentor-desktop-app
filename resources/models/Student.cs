using SR38_2021_POP2022.resources.enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR38_2021_POP2022.resources.models
{
    public class Student : User, INotifyPropertyChanged
    {
        private List<Session> reservedSessions;

        public Student()
        {
        }

        public Student(string firstName, string lastName, string personalIdentityNumber, string email, string password, EUserType userType, EGender gender, Address address, bool active, List<Session> reservedClasses) : base(firstName, lastName, personalIdentityNumber, email, password, userType, gender, active, address)
        {
            this.reservedSessions = reservedClasses;
        }

        public List<Session> ReservedSessions { get => reservedSessions; set { reservedSessions = value; OnPropertyChanged("reservedSessions"); } }

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
