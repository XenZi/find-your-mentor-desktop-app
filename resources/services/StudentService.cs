﻿using SR38_2021_POP2022.resources.managers;
using SR38_2021_POP2022.resources.dao;
using SR38_2021_POP2022.resources.enums;
using SR38_2021_POP2022.resources.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace SR38_2021_POP2022.resources.services
{
    class StudentService
    {
        private StudentRepository repository;
        private AddressService addressService;
        public StudentService()
        {
            repository = new StudentRepository();
            addressService = new AddressService();
        }

        public void InitializeService()
        {
            FillManager();
            //UpdateStudent("Mateja", "Rilak", "123123", "rilaktest@gmail.com", "password", EUserType.Student, EGender.Male, "Vinogradarska", new int[] {});
            //DeleteStudent("123123");
            Console.WriteLine("Student Service -> Service initialized");
        }

        private void FillManager()
        {
            repository.Read();
        }
        
        public Student FindByPersonalIDAndPassword(string personalID, string password)
        {
            Student a = (Student)StudentManager.GetInstance().AllStudents.ToList().Find(student => student.PersonalIdentityNumber == personalID && student.Password == password);
            return a;
        }

        public ObservableCollection<Student> GetAllStudents()
        {
            return StudentManager.GetInstance().AllStudents;
        }
        public void CreateStudent(string firstName, string lastName, string personalIdentityNumber, string email, string password, EUserType userType, EGender genderType, string streetName, int streetNumber, string cityName, string country)
        {
            Address enteredAddress = addressService.GetAddressByStreetNameNumberAndCity(streetName, streetNumber, cityName);

            if (enteredAddress == null)
            {
                addressService.CreateAddress(streetName, streetNumber, cityName, country);
                enteredAddress = addressService.GetAddressByStreetNameNumberAndCity(streetName, streetNumber, cityName);
            }
            repository.Create(firstName, lastName, personalIdentityNumber, email, password, userType, genderType, true, enteredAddress, new List<Session>());
        }

        private void UpdateStudent(string firstName, string lastName, string personalIdentityNumber, string email, string password, EUserType userType, EGender genderType, string address, int[] sessionIDs)
        {
            repository.Update(firstName, lastName, personalIdentityNumber, email, password, userType, genderType, true, AddressManager.GetInstance().GetAddressByStreetName(address), SessionManager.GetInstance().GetSessionsBasedByID(sessionIDs).ToList());
        }

        private void DeleteStudent(string personalIdentityNumber)
        {
            repository.Delete(personalIdentityNumber);
        }

    }
}
