using SR38_2021_POP2022.resources.managers;
using SR38_2021_POP2022.utilities.file_related_utilities;
using SR38_2021_POP2022.resources.models;
using SR38_2021_POP2022.utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR38_2021_POP2022.resources.dao
{
    class SchoolRepository { 
        public void Read() { 
            string[] readedFromFile = FileHandler.ReadFile(SchoolManager.FILE_PATH);
            foreach(string line in readedFromFile)
            {
                if (line != "") SchoolManager.GetInstance().AllSchools.Add(FileSchoolFormatter.CreateSchoolFromFile(line.Split('|')));
            }
        }

        public void Create(string name, Address address, List<Language> languages, bool active = true)
        {
            int id = IDGenerator.GenerateSchoolID();
            School school = new School(id, name, address, languages, active);
            SchoolManager.GetInstance().AllSchools.Add(school);
            FileHandler.WriteFile(SchoolManager.FILE_PATH, FileSchoolFormatter.CreateStringFormatForFileStorage(school));
        }
    
        public void Update(int id, string name, Address address, List<Language> languages)
        {
            School updatedSchool = SchoolManager.GetInstance().GetSchoolById(id);
            updatedSchool.Name = name;
            updatedSchool.Address = address;
            updatedSchool.AllLanguages = languages;
            FileHandler.UpdateFile(SchoolManager.FILE_PATH, FileSchoolFormatter.CreateStringFormatForFileStorage(updatedSchool));
        }

        public void Delete(int id)
        {
            School updatedSchool = SchoolManager.GetInstance().GetSchoolById(id);
            updatedSchool.Active = false;
            FileHandler.UpdateFile(SchoolManager.FILE_PATH, FileSchoolFormatter.CreateStringFormatForFileStorage(updatedSchool));
        }
    }
}
