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
    class LanguageRepository
    {
        public void Read()
        {
            string[] readedFromFile = FileHandler.ReadFile(LanguageManager.FILE_PATH);
            foreach(string line in readedFromFile)
            {
                if (line != "") LanguageManager.GetInstance().AllLanguages.Add(FileLanguageFormatter.CreateLanguageFromFile(line.Split('|')));
            }
        }

        public void Create(string languageName, bool active = true)
        {
            int id = IDGenerator.GenerateLanguageID();
            Language language = new Language(id, languageName, active);
            LanguageManager.GetInstance().AllLanguages.Add(language);
            FileHandler.WriteFile(LanguageManager.FILE_PATH, FileLanguageFormatter.CreateStringFormatForFileStorage(language));
        }

        public void Update(int id, string languageName)
        {
            Language language = LanguageManager.GetInstance().GetLanguageById(id);
            language.LanguageName = languageName;
            FileHandler.UpdateFile(LanguageManager.FILE_PATH, FileLanguageFormatter.CreateStringFormatForFileStorage(language));
        }

        public void Delete(int id)
        {
            Language language = LanguageManager.GetInstance().GetLanguageById(id);
            language.Active = false;
            FileHandler.UpdateFile(LanguageManager.FILE_PATH, FileLanguageFormatter.CreateStringFormatForFileStorage(language));
        }
    }
}
