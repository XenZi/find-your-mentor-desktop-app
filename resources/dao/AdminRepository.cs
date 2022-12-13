using SR38_2021_POP2022.resources.enums;
using SR38_2021_POP2022.resources.managers;
using SR38_2021_POP2022.resources.models;
using SR38_2021_POP2022.utilities;
using SR38_2021_POP2022.utilities.file_related_utilities.file_formatters;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR38_2021_POP2022.resources.dao
{
    class AdminRepository
    {

        public void Read()
        {

            using (SqlConnection conn = new SqlConnection(DBHandler.connectionString))
            {
                conn.Open();
                SqlCommand command = conn.CreateCommand();
                command.CommandText = @"select * from Admin where is_active = 1";
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Admin admin = new Admin();
                    admin.PersonalIdentityNumber = reader.GetString(0);
                    admin.FirstName = reader.GetString(1);
                    admin.LastName = reader.GetString(2);
                    admin.Gender = (EGender)Enum.Parse(typeof(EGender), reader.GetString(3));
                    admin.Address = AddressManager.GetInstance().GetAddressById(reader.GetInt32(4));
                    admin.Email = reader.GetString(5);
                    admin.Password = reader.GetString(6);
                    admin.UserType = (EUserType)Enum.Parse(typeof(EUserType), reader.GetString(7));
                    admin.Active = reader.GetBoolean(8);
                    AdminManager.GetInstance().AllAdmins.Add(admin);
                }

                conn.Close();
            }
        }
    }
}
