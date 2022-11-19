using SR38_2021_POP2022.resources.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR38_2021_POP2022.resources.models
{
    public class Admin : User
    {
        public Admin() { }
        public Admin(string firstName, string lastName, string personalIdentityNumber, string email, string password, EUserType userType, EGender gender, bool active, Address address) : base(firstName, lastName, personalIdentityNumber, email, password, userType, gender, active, address)
        {
                
        }
    }
}
