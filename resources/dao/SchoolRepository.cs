using SR38_2021_POP2022.resources.managers;
using SR38_2021_POP2022.utilities.file_related_utilities;
using SR38_2021_POP2022.resources.models;
using SR38_2021_POP2022.utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Net;
using System.Xml.Linq;

namespace SR38_2021_POP2022.resources.dao
{
    class SchoolRepository { 
        public void Read() {
            using (SqlConnection conn = new SqlConnection(DBHandler.connectionString))
            {
                conn.Open();
                SqlCommand command = conn.CreateCommand();
                command.CommandText = @"select * from School where is_active = 1";
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    School school = new School();
                    school.Id = reader.GetInt32(0);
                    school.Name = reader.GetString(1);
                    school.Address = AddressManager.GetInstance().GetAddressById(reader.GetInt32(2));
                    school.Active = reader.GetBoolean(3);
                    school.AllLanguages = initializeLanguages(school.Id);
                    SchoolManager.GetInstance().AllSchools.Add(school);
                }

                conn.Close();
            }
        }

        public void Create(string name, Address address, List<Language> languages, bool active = true)
        {
            int id = IDGenerator.GenerateSchoolID();
            School school = new School(id, name, address, languages, active);
            SchoolManager.GetInstance().AllSchools.Add(school);
            using (SqlConnection conn = new SqlConnection(DBHandler.connectionString))
            {
                conn.Open();
                using (SqlCommand cmd =
                    new SqlCommand("insert into School values(@id ,@school_name, @address_number, @is_active)", conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@school_name", name);
                    cmd.Parameters.AddWithValue("@address_number", address.Id);
                    cmd.Parameters.AddWithValue("@is_active", 1);
                    cmd.ExecuteNonQuery();
                }

                languages.ForEach(lang =>
                {
                    using (SqlCommand cmd =
                    new SqlCommand("insert into hasLanguage values(@school_id, @language_id)", conn))
                    {
                        cmd.Parameters.AddWithValue("@school_id", id);
                        cmd.Parameters.AddWithValue("@language_id", lang.Id);
                        cmd.ExecuteNonQuery();
                    }
                });

                conn.Close();
            }
        }
    
        public void Update(int id, string name, Address address, List<Language> languages)
        {
            School updatedSchool = SchoolManager.GetInstance().GetSchoolById(id);
            
            updatedSchool.Name = name;
            updatedSchool.Address = address;
            
            updatedSchool.AllLanguages = languages;
            using (SqlConnection conn = new SqlConnection(DBHandler.connectionString))
            {
                conn.Open();
                using (SqlCommand cmd =
                    new SqlCommand("update School set school_name=@school_name, address_number=@address_number where id=@id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@school_name", name);
                    cmd.Parameters.AddWithValue("@address_number", address.Id);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
             DBHandler.DeleteAllLanguagesFromHasLanguagesBasedBySchoolID(id);
            languages.ForEach(lang =>
            {
                DBHandler.InsertIntoHasLanguages(updatedSchool.Id, lang.Id);
            });
        }

        public void Delete(int id)
        {
            School updatedSchool = SchoolManager.GetInstance().GetSchoolById(id);
            updatedSchool.Active = false;
            using (SqlConnection conn = new SqlConnection(DBHandler.connectionString))
            {
                conn.Open();
                using (SqlCommand cmd =
                    new SqlCommand("update School set is_active = 0 where id=@id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        private List<Language> initializeLanguages(int id)
        {
            List<Language> schoolLanguageList = new List<Language>();

            using (SqlConnection conn = new SqlConnection(DBHandler.connectionString))
            {
                conn.Open();
                SqlCommand command = conn.CreateCommand();
                command.CommandText = $"select language_id from hasLanguage where school_id = @school_id";
                command.Parameters.AddWithValue("@school_id", id);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.Write(reader.GetInt32(0).ToString());
                    Language language = LanguageManager.GetInstance().GetLanguageById(reader.GetInt32(0));
                    Console.WriteLine(language.ToString());
                    schoolLanguageList.Add(language);
                }

                conn.Close();
            }
            return schoolLanguageList;
        }
    }
}
