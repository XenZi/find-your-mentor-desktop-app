using SR38_2021_POP2022.utilities.exceptions;
using SR38_2021_POP2022.resources.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace SR38_2021_POP2022.resources.managers
{
    class AddressManager
    {
        private static AddressManager instance;
        private ObservableCollection<Address> allAddresses = new ObservableCollection<Address> ();
        public static readonly string FILE_PATH = "C:\\Users\\rilak\\source\\repos\\SR38-2021-POP2022\\SR38-2021-POP2022\\data\\txt\\addresses.txt";

        public ObservableCollection<Address> AllAddresses { get => allAddresses; set => allAddresses = value; }

        private AddressManager() { }

        public static AddressManager GetInstance()
        {
            if (instance == null) instance = new AddressManager();
            return instance;
        }

        public Address GetAddressById(int id)
        {
            Address foundAddress = allAddresses.ToList().Find(x => x.Id == id);
            if (foundAddress == null)
            {
                throw new AddressNotFoundException("Address that you've searched for isn't found");
            }
            return foundAddress;
        }

        public Address GetAddressByStreetName(string name)
        {

            Address foundAddress = allAddresses.ToList().Find(x => x.Street == name);
            if (foundAddress == null)
            {
                throw new AddressNotFoundException("Address that you've searched for isn't found");
            }
            return foundAddress;
        }

        public Address GetAddressByStreetNameAndNumber(string name, int number)
        {
            Address foundAddress = allAddresses.ToList().Find(x => x.Street == name && x.Number == number);
            if (foundAddress == null)
            {
                throw new AddressNotFoundException("Address that you've been searching for isn't found.");
            }
            return foundAddress;
        }

        public Address GetAddressByStreetNameNumberAndCity(string name, int number, string city)
        {
            Address foundAddress = allAddresses.ToList().Find(x => x.Street == name && x.Number == number && x.City == city);
            if (foundAddress == null)
            {
                throw new AddressNotFoundException("Address that you've been searching for isn't found.");
            }
            return foundAddress;
        }
    }
}
