using SR38_2021_POP2022.resources.managers;
using SR38_2021_POP2022.resources.enums;
using SR38_2021_POP2022.resources.models;
using SR38_2021_POP2022.utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR38_2021_POP2022.resources.dao
{
    class TeacherRepository
    {
        public void Read()
        {

            string[] readedFomFile = FileHandler.ReadFile(TeacherManager.FILE_PATH);
            foreach(string line in readedFomFile)
            {
                if (line != "") TeacherManager.GetInstance().AllTeachers.Add(FileTeacherFormatter.CreateTeacherFromFile(line.Split('|')));
            }
        }

        public void Create(string firstName, string lastName, string personalIdentityNumber, string email, string password, EUserType userType, EGender gender, Address address, bool active, School workingSchool, List<Language> teachingLanguages, List<Session> sessions)
        {
            Teacher teacher = new Teacher(firstName, lastName, personalIdentityNumber, email, password, userType, gender, address, active, workingSchool, teachingLanguages, sessions);
            TeacherManager.GetInstance().AllTeachers.Add(teacher);
            FileHandler.WriteFile(TeacherManager.FILE_PATH, FileTeacherFormatter.CreateStringFormatForFile(teacher));
        }

        public void Update(string firstName, string lastName, string personalIdentityNumber, string email, string password, EUserType userType, EGender gender, Address address, bool active, School workingSchool, List<Language> teachingLanguages, List<Session> sessions)
        {
            Teacher teacher = TeacherManager.GetInstance().GetTeacherByIdentityNumber(personalIdentityNumber);
            teacher.FirstName = firstName;
            teacher.LastName = lastName;
            teacher.Email = email;
            teacher.Password = password;
            teacher.UserType = userType;
            teacher.Gender = gender;
            teacher.Address = address;
            teacher.Active = active;
            teacher.WorkingSchool = workingSchool;
            teacher.TeachingLanguages = teachingLanguages;
            teacher.Sessions = sessions;
            FileHandler.UpdateFile(TeacherManager.FILE_PATH, FileTeacherFormatter.CreateStringFormatForFile(teacher));
        }

        public void Delete(string personalIdentityNumber)
        {
            Teacher teacher = TeacherManager.GetInstance().GetTeacherByIdentityNumber(personalIdentityNumber);
            teacher.Active = false;
            FileHandler.UpdateFile(TeacherManager.FILE_PATH,FileTeacherFormatter.CreateStringFormatForFile(teacher));
        }
    }
}
