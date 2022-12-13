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
using System.Data.SqlClient;
using System.IO;

namespace SR38_2021_POP2022.resources.dao
{
    class SessionRepository
    {

        public void Read()
        {
            using (SqlConnection conn = new SqlConnection(DBHandler.connectionString))
            {
                conn.Open();
                SqlCommand command = conn.CreateCommand();
                command.CommandText = @"select * from Session";
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Session session = new Session();
                    session.Id = reader.GetInt32(0);
                    session.Teacher = TeacherManager.GetInstance().GetTeacherByIdentityNumber(reader.GetString(1));
                    session.ReservedDate = reader.GetDateTime(2);
                    session.StartingTime = reader.GetTimeSpan(3).ToString();
                    session.ClassLength = reader.GetInt32(4);
                    session.Status = (EClassStatus) Enum.Parse(typeof (EClassStatus), reader.GetString(5));
                    session.Student = reader.IsDBNull(6) ? null :
                        StudentManager.GetInstance().GetStudentByIdentityNumber(reader.GetString(6));
                    session.Active = reader.GetBoolean(7);
                    SessionManager.GetInstance().AllSessions.Add(session);
                }

                conn.Close();
            }
        }

        public void Create(Teacher teacher, DateTime reservedDate, string startingTime, int classLength, EClassStatus status, Student student, bool active = true)
        {
            int id = IDGenerator.GenerateSessionID();
            Session session = new Session(id, teacher, reservedDate, startingTime, classLength, status, student, active);
            SessionManager.GetInstance().AllSessions.Add(session);
            using (SqlConnection conn = new SqlConnection(DBHandler.connectionString))
            {
                conn.Open();
                using (SqlCommand cmd =
                    new SqlCommand("insert into Session values(@id, @teacher_id, @session_date, @session_time, @session_length, @session_status, @student_id, @is_active)", conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@teacher_id", teacher.PersonalIdentityNumber);
                    cmd.Parameters.AddWithValue("@session_date", reservedDate);
                    cmd.Parameters.AddWithValue("@session_time", TimeSpan.Parse(startingTime));
                    cmd.Parameters.AddWithValue("@session_length", classLength);
                    cmd.Parameters.AddWithValue("@session_status", status.ToString());
                    cmd.Parameters.AddWithValue("@student_id", DBNull.Value);
                    cmd.Parameters.AddWithValue("@is_active", 1);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
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
            using (SqlConnection conn = new SqlConnection(DBHandler.connectionString))
            {
                conn.Open();
                using (SqlCommand cmd =
                    new SqlCommand("update Session set teacher_id=@teacher_id,session_date=@session_date,session_time=@session_time,session_length=@session_length where id=@id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@teacher_id", teacher.PersonalIdentityNumber);
                    cmd.Parameters.AddWithValue("@session_date", reservedDate);
                    cmd.Parameters.AddWithValue("@session_time", TimeSpan.Parse("21:00"));
                    cmd.Parameters.AddWithValue("@session_length", classLength);
                    int rows = cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        public void Delete(int id)
        {
            Session session = SessionManager.GetInstance().GetSessionById(id);
            session.Active = false;
            using (SqlConnection conn = new SqlConnection(DBHandler.connectionString))
            {
                conn.Open();
                using (SqlCommand cmd =
                    new SqlCommand("update Session set is_active=0 where id=@id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    
                    int rows = cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }
    }
}
