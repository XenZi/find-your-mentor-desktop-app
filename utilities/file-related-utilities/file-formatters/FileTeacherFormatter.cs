using SR38_2021_POP2022.resources.managers;
using SR38_2021_POP2022.utilities.file_related_utilities;
using SR38_2021_POP2022.utilities.file_related_utilities.file_formatters;
using SR38_2021_POP2022.resources.enums;
using SR38_2021_POP2022.resources.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR38_2021_POP2022.resources.dao
{
    class FileTeacherFormatter
    {

        public static Teacher CreateTeacherFromFile(string[] splittedLine)
        {
            Teacher teacher = new Teacher();
            teacher.PersonalIdentityNumber = splittedLine[0];
            teacher.FirstName = splittedLine[1];
            teacher.LastName = splittedLine[2];
            teacher.Email = splittedLine[3];
            teacher.Password = splittedLine[4];
            teacher.UserType = (EUserType)int.Parse(splittedLine[5]);
            teacher.Gender = (EGender)int.Parse(splittedLine[6]);
            teacher.Address = AddressManager.GetInstance().GetAddressById(int.Parse(splittedLine[7]));
            teacher.WorkingSchool = SchoolManager.GetInstance().GetSchoolById(int.Parse(splittedLine[8]));
            teacher.TeachingLanguages = LanguageManager.GetInstance().GetLanguagesBasedById((FileLanguageFormatter.SplitLanguagesFromFile(splittedLine[9]))).ToList();
            teacher.Sessions = new List<Session>();
            teacher.Active = bool.Parse(splittedLine[11]);
            return teacher;
        }
        
        public static string CreateStringFormatForFile(Teacher teacher)
        {
            return String.Format("{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}", teacher.PersonalIdentityNumber, teacher.FirstName, teacher.LastName, teacher.Email, teacher.Password, (int) teacher.UserType, (int) teacher.Gender, teacher.Address.Id, teacher.WorkingSchool.Id, FileLanguageFormatter.CreateStringRepresentationOfLanguageIDs(teacher.TeachingLanguages), FileSessionFormatter.CreateStringRepresentationOfSessionIDs(teacher.Sessions), teacher.Active);
        }
    }
}
