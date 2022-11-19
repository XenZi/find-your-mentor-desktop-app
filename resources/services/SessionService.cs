using SR38_2021_POP2022.resources.dao;
using SR38_2021_POP2022.resources.managers;
using SR38_2021_POP2022.resources.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using SR38_2021_POP2022.resources.models;

namespace SR38_2021_POP2022.resources.services
{
    class SessionService
    {
        SessionRepository repository;

        public SessionService()
        {
            repository = new SessionRepository();
        }

        public void InitializeService()
        {
            FillModelManager();
            //Create(1, "1234567891011", DateTime.Now, "21:00", 30, EClassStatus.AVAILABLE, "123123");
            //Update(1, "1234567891011", DateTime.Now, "21:00", 30, EClassStatus.RESERVED, "123123");
            Console.WriteLine("Session Service -> Service initialized");
        }

        private void FillModelManager()
        {
            repository.Read();
        }

        public ObservableCollection<Session> GetAllSessions()
        {
            return new ObservableCollection<Session>(SessionManager.GetInstance().AllSessions.Where(session => session.Active).ToList());
        }

        public void Create(string teacherID, DateTime reservedDate, string startingTime, int classLength, EClassStatus status, string studentID)
        {
            repository.Create(TeacherManager.GetInstance().GetTeacherByIdentityNumber(teacherID), reservedDate, startingTime, classLength, status, StudentManager.GetInstance().GetStudentByIdentityNumber(studentID));
        }

        public void Update(int id, string teacherID, DateTime reservedDate, string startingTime, int classLength, EClassStatus status, string studentID)
        {
            repository.Update(id, TeacherManager.GetInstance().GetTeacherByIdentityNumber(teacherID), reservedDate, startingTime, classLength, status, StudentManager.GetInstance().GetStudentByIdentityNumber(studentID));
        }

        public void Delete(int id)
        {
            repository.Delete(id);
        }
    }
}
