using SR38_2021_POP2022.resources.managers;
using SR38_2021_POP2022.utilities.file_related_utilities;
using SR38_2021_POP2022.resources.models;
using SR38_2021_POP2022.utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SR38_2021_POP2022.resources.dao
{
    class AddressRepository
    {
        public void Read()
        {
            string[] readedFromFile = FileHandler.ReadFile(AddressManager.FILE_PATH);
            foreach(string line in readedFromFile) {
                if (line != "") AddressManager.GetInstance().AllAddresses.Add(FileAddressFormatter.createAddressFromFile(line.Split('|')));
            }

        }

        public void Create(string street, int number, string city, string country, bool active = true)
        {
            int id = IDGenerator.GenerateAddressID();
            MessageBox.Show(id.ToString());
            Address address = new Address(id, street, number, city, country, active);
            AddressManager.GetInstance().AllAddresses.Add(address);
            FileHandler.WriteFile(AddressManager.FILE_PATH, FileAddressFormatter.createStringFormatForFileStorage(address));
        }

        public void Update(int id, string street, int number, string city, string country)
        {
            Address updatedAddress = AddressManager.GetInstance().GetAddressById(id);
            updatedAddress.Street = street;
            updatedAddress.Number = number;
            updatedAddress.City = city;
            updatedAddress.Country = country;
            FileHandler.UpdateFile(AddressManager.FILE_PATH, FileAddressFormatter.createStringFormatForFileStorage(updatedAddress));
        }

        public void Delete(int id)
        {
            Address updatedAddress = AddressManager.GetInstance().GetAddressById(id);
            updatedAddress.Active = false;
            FileHandler.UpdateFile(AddressManager.FILE_PATH, FileAddressFormatter.createStringFormatForFileStorage(updatedAddress));
        }
    }
}
