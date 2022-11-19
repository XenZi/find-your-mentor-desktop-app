using SR38_2021_POP2022.resources.managers;
using SR38_2021_POP2022.utilities;
using SR38_2021_POP2022.utilities.file_related_utilities.file_formatters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR38_2021_POP2022.resources.dao
{
    class AdminRepository
    {

        public void Read()
        {
            string[] readedFromFile = FileHandler.ReadFile(AdminManager.FILE_PATH);
            foreach(string line in readedFromFile)
            {
                if (line != "")
                {
                    AdminManager.GetInstance().AllAdmins.Add(FileAdminFormatter.createAdminFromFile(line.Split('|')));
                }
            }
        }
    }
}
