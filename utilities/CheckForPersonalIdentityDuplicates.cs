using SR38_2021_POP2022.resources.managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR38_2021_POP2022.utilities
{
    class CheckForPersonalIdentityDuplicates
    {
        public static bool CheckForDuplicates(string personalID)
        {
            bool isExistingInTeachers = TeacherManager.GetInstance().AllTeachers.Any(teacher => teacher.PersonalIdentityNumber == personalID);
            bool isExistingInStudents = StudentManager.GetInstance().AllStudents.Any(student => student.PersonalIdentityNumber == personalID);
            bool isExistingInAdmins = AdminManager.GetInstance().AllAdmins.Any(admin => admin.PersonalIdentityNumber == personalID);
            return isExistingInStudents || isExistingInTeachers || isExistingInAdmins; 
        }
    }
}
