using SR38_2021_POP2022.resources.models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR38_2021_POP2022.resources.managers
{
    class AdminManager
    {
        private static AdminManager instance;
        private ObservableCollection<Admin> allAdmins = new ObservableCollection<Admin>();
        public static readonly string FILE_PATH = "C:\\Users\\rilak\\source\\repos\\SR38-2021-POP2022\\SR38-2021-POP2022\\data\\txt\\admins.txt";

        public ObservableCollection<Admin> AllAdmins { get => allAdmins; set => allAdmins = value; }

        public AdminManager() { }

        public static AdminManager GetInstance()
        {
            if (instance == null) instance = new AdminManager();
            return instance;
        }
    }
}
