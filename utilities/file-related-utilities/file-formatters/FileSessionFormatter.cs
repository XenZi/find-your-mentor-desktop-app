using SR38_2021_POP2022.resources.managers;
using SR38_2021_POP2022.resources.enums;
using SR38_2021_POP2022.resources.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR38_2021_POP2022.utilities.file_related_utilities.file_formatters
{
    class FileSessionFormatter { 
        public static Session CreateClassFromFile(string[] splittedLine)
        {
            Session session = new Session();
            session.Id = int.Parse(splittedLine[0]);
            session.Teacher = TeacherManager.GetInstance().GetTeacherByIdentityNumber(splittedLine[1]);
            session.ReservedDate = DateTime.Parse(splittedLine[2]);
            session.StartingTime = splittedLine[3];
            session.ClassLength = int.Parse(splittedLine[4]);
            session.Status = (EClassStatus)int.Parse(splittedLine[5]);
            session.Student = StudentManager.GetInstance().GetStudentByIdentityNumber(splittedLine[6]);
            session.Active = bool.Parse(splittedLine[7]);
            return session;
        }

        public static string CreateStringFormatForFileStorage(Session session)
        {
            return String.Format("{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}", session.Id, session.Teacher.PersonalIdentityNumber, session.ReservedDate, session.StartingTime, session.ClassLength, (int)session.Status, session.Student.PersonalIdentityNumber, session.Active);
        }
        public static string CreateStringRepresentationOfSessionIDs(List<Session> sessions)
        {
            StringBuilder buildedString = new StringBuilder();
            for(int i=0;i<sessions.Count;i++)
            {
                if (i == sessions.Count - 1)
                {
                    buildedString.Append(sessions[i].Id);
                }
                else
                {
                    buildedString.Append(sessions[i].Id + ",");
                }
            }
            return buildedString.ToString();
        }

        public static string[] SplitSessionsFromFile(string line)
        {
            string[] splittedAddresses = line.Split(',');
            return splittedAddresses;
        }
    }
}
