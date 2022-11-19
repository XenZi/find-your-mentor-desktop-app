using SR38_2021_POP2022.resources.dao;
using SR38_2021_POP2022.resources.managers;
using SR38_2021_POP2022.utilities.exceptions;
using SR38_2021_POP2022.resources.enums;
using SR38_2021_POP2022.resources.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Collections.ObjectModel;

namespace SR38_2021_POP2022.resources.services
{
    class TeacherService
    {
        TeacherRepository repository;

        public TeacherService()
        {
            repository = new TeacherRepository();
        }

        public void InitializeService()
        {
            FillManager();
            
        }

        private void FillManager()
        {
            repository.Read();
        }

        public List<Teacher> GetTeachersBasedBySchoolID(int schoolID)
        {
            List<Teacher> list = TeacherManager.GetInstance().AllTeachers.ToList().FindAll(teacher => teacher.WorkingSchool.Id == schoolID);
            return list;
        }

        public ObservableCollection<Teacher> GetAllTeachers()
        {
            return TeacherManager.GetInstance().AllTeachers;
        }
        public Teacher FindByPersonalIDAndPassword(string personalID, string password)
        {
            Teacher a = (Teacher)TeacherManager.GetInstance().AllTeachers.ToList().Find(teacher => teacher.PersonalIdentityNumber == personalID && teacher.Password == password);
            return a;
        }
        private void CreateTeacher(string firstName, string lastName, string personalIdentityNumber, string email, string password, EUserType userType, EGender genderType, string address, bool active, string schoolName, int[] teachingLanguageIDs, int[] sessionIDsFromArray)
        {
            try
            {
                repository.Create(firstName, lastName, personalIdentityNumber, email, password, EUserType.Teacher, genderType, AddressManager.GetInstance().GetAddressByStreetName(address), active = true, SchoolManager.GetInstance().GetSchoolByName(schoolName), LanguageManager.GetInstance().GetLanguagesBasedById(teachingLanguageIDs), SessionManager.GetInstance().GetSessionsBasedByID(sessionIDsFromArray).ToList());
            }
            catch (AddressNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch(SchoolNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch(LanguageNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch(SessionNotFoundException exception)
            {
                Console.Write(exception);
            }
        }

        private void UpdateTeacher(string firstName, string lastName, string personalIdentityNumber, string email, string password, EUserType userType, EGender genderType, string address, bool active, string schoolName, int[] teachingLanguageIDs, int[] sessionIDsFromArray)
        {
            Address foundAddress = AddressManager.GetInstance().GetAddressByStreetName(address);
            School workingSchool = SchoolManager.GetInstance().GetSchoolByName(schoolName);
            List<Language> teachingLanguages = LanguageManager.GetInstance().GetLanguagesBasedById(teachingLanguageIDs);
            List<Session> sessions = SessionManager.GetInstance().GetSessionsBasedByID(sessionIDsFromArray).ToList();
            repository.Update(firstName, lastName, personalIdentityNumber, email, password, userType, genderType, foundAddress, active, workingSchool, teachingLanguages, sessions);
        }

        private void DeleteTeacher(string identityNumber)
        {
            repository.Delete(identityNumber);
        }
    }
}
