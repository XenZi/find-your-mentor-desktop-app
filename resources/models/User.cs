using SR38_2021_POP2022.resources.enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR38_2021_POP2022.resources.models
{
    public abstract class User : INotifyPropertyChanged
    {


        protected string firstName;
        protected string lastName;
        protected string personalIdentityNumber;
        protected string email;
        protected string password;
        protected EUserType userType;
        protected EGender gender;
        protected bool active;
        protected Address address;

        protected User() { }

        protected User(string firstName, string lastName, string personalIdentityNumber, string email, string password, EUserType userType, EGender gender, bool active, Address address)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.personalIdentityNumber = personalIdentityNumber;
            this.email = email;
            this.password = password;
            this.userType = userType;
            this.gender = gender;
            this.active = active;
            this.address = address;
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; OnPropertyChanged("firstName"); }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; OnPropertyChanged("lastName"); }
        }
        public string PersonalIdentityNumber
        {
            get { return personalIdentityNumber; }
            set { personalIdentityNumber = value; OnPropertyChanged("personalIdentityNumber"); }
        }
        public string Email
        {
            get { return email; }
            set { email = value; OnPropertyChanged("email"); }
        }
        public string Password
        {
            get { return password; }
            set { password = value; OnPropertyChanged("password"); }
        }
        public EUserType UserType
        {
            get { return userType; }
            set { userType = value; OnPropertyChanged("userType"); }
        }
        public EGender Gender
        {
            get { return gender; }
            set { gender = value; OnPropertyChanged("gender"); }
        }
        public Address Address
        {
            get { return address; }
            set { address = value; OnPropertyChanged("address"); }
        }

        public bool Active
        {
            get { return active; }
            set { active = value; OnPropertyChanged("active"); }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(String name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}
