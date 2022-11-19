using SR38_2021_POP2022.resources.managers;
using SR38_2021_POP2022.utilities.file_related_utilities.file_formatters;
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
    class SessionRepository
    {

        public void Read()
        {
            string[] readedFromFile = FileHandler.ReadFile(SessionManager.FILE_PATH);
            foreach(string line in readedFromFile)
            {
                if (line != "") SessionManager.GetInstance().AllSessions.Add(FileSessionFormatter.CreateClassFromFile(line.Split('|')));
            }
        }

        public void Create(Teacher teacher, DateTime reservedDate, string startingTime, int classLength, EClassStatus status, Student student, bool active = true)
        {
            int id = IDGenerator.GenerateSessionID();
            Session session = new Session(id, teacher, reservedDate, startingTime, classLength, status, student, active);
            SessionManager.GetInstance().AllSessions.Add(session);
            FileHandler.WriteFile(SessionManager.FILE_PATH, FileSessionFormatter.CreateStringFormatForFileStorage(session));
        }

        public void Update(int id, Teacher teacher, DateTime reservedDate, string startingTime, int classLength, EClassStatus status, Student student, bool active = true)
        {
            Session session = SessionManager.GetInstance().GetSessionById(id);
            session.Teacher = teacher;
            session.ReservedDate = reservedDate;
            session.StartingTime = startingTime;
            session.ClassLength = classLength;
            session.Status = status;
            session.Student = student;
            FileHandler.UpdateFile(SessionManager.FILE_PATH, FileSessionFormatter.CreateStringFormatForFileStorage(session));
        }

        public void Delete(int id)
        {
            Session session = SessionManager.GetInstance().GetSessionById(id);
            session.Active = false;
            FileHandler.UpdateFile(SessionManager.FILE_PATH, FileSessionFormatter.CreateStringFormatForFileStorage(session));
        }
    }
}
