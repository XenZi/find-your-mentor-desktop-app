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
using System.Windows;

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

        public ObservableCollection<Session> GetSessionsBasedByTeacherIDAndDate(string id, DateTime date)
        {
            return new ObservableCollection<Session>(SessionManager.GetInstance().AllSessions.Where(session => session.Teacher.PersonalIdentityNumber == id && session.ReservedDate.Date == date.Date));
        }
        public ObservableCollection<Session> GetSessionsBasedByTeacherID(string id)
        {
            return new ObservableCollection<Session>(SessionManager.GetInstance().AllSessions.Where(session => session.Teacher.PersonalIdentityNumber == id));
        }
        public ObservableCollection<Session> GetAllSessions()
        {
            return new ObservableCollection<Session>(SessionManager.GetInstance().AllSessions.Where(session => session.Active).ToList());
        }

        public void Create(Teacher teacher, DateTime reservedDate, string startingTime, int classLength, EClassStatus status, Student student = null)
        {
            repository.Create(teacher, reservedDate, startingTime, classLength, status, student);
        }

        public void Update(int id, Teacher teacher, DateTime reservedDate, string startingTime, int classLength, EClassStatus status, Student student = null)
        {
            repository.Update(id, teacher, reservedDate, startingTime, classLength, status, student);
        }

        public void Delete(int id)
        {
            repository.Delete(id);
        }
    }
}
