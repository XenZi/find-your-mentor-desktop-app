using SR38_2021_POP2022.resources.enums;
using SR38_2021_POP2022.resources.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR38_2021_POP2022.resources.interfaces
{
    public interface IStudentRepository
    {
        void createStudent(string firstName, string lastName, string personalIdentityNumber, string email, string password, EUserType userType, EGender gender, Address address, bool active, Session[] reserved
            );
        void updateStudent(string firstName, string lastName, string personalIdentityNumber, string email, string password, EUserType userType, EGender gender, Address address, bool active, Session[] reservedClasses);
        void readStudent();
        void deleteStudent(string personalIdentityNumber);
    }
}
