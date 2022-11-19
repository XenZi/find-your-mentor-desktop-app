using SR38_2021_POP2022.resources.dao;
using SR38_2021_POP2022.resources.managers;
using SR38_2021_POP2022.utilities.file_related_utilities;
using SR38_2021_POP2022.resources.enums;
using SR38_2021_POP2022.resources.interfaces;
using SR38_2021_POP2022.resources.models;
using SR38_2021_POP2022.utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR38_2021_POP2022.resources.dao
{
    class StudentRepository
    {
        
        public void Read()
        {
            string[] readedFomFile = FileHandler.ReadFile(StudentManager.FILE_PATH);
            foreach (string line in readedFomFile)
            {
                if (line != "") {
StudentManager.GetInstance().AllStudents.Add(FileStudentFormatter.CreateStudentFromFile(line.Split('|')));
                    
                }
            }
        }

        public void Create(string firstName, string lastName, string personalIdentityNumber, string email, string password, EUserType userType, EGender gender, bool active, Address address, List<Session> reservedSessions)
        {
            Student student = new Student(firstName, lastName, personalIdentityNumber, email, password, userType, gender, address, active, reservedSessions);
            StudentManager.GetInstance().AllStudents.Add(student);
            FileHandler.WriteFile(StudentManager.FILE_PATH,
                FileStudentFormatter.CreateStringFormatForFile(student));
        }

        public void Update(string firstName, string lastName, string personalIdentityNumber, string email, string password, EUserType userType, EGender gender, bool active, Address address, List<Session> reservedSessions)
        {
            Student student = StudentManager.GetInstance().GetStudentByIdentityNumber(personalIdentityNumber);
            student.FirstName = firstName;
            student.LastName = lastName;
            student.Email = email;
            student.Password = password;
            student.UserType = userType;
            student.Gender = gender;
            student.Address = address;
            student.Active = active;
            student.ReservedSessions = reservedSessions;
            FileHandler.UpdateFile(StudentManager.FILE_PATH, FileStudentFormatter.CreateStringFormatForFile(student));
        }

        public void Delete(string personalIdentityNumber)
        {
            Student student = StudentManager.GetInstance().GetStudentByIdentityNumber(personalIdentityNumber);
            student.Active = false;
            FileHandler.UpdateFile(StudentManager.FILE_PATH, FileStudentFormatter.CreateStringFormatForFile(student));
        }
    }
}
