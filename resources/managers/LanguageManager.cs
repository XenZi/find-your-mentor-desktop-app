using SR38_2021_POP2022.utilities.exceptions;
using SR38_2021_POP2022.resources.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace SR38_2021_POP2022.resources.managers
{
    class LanguageManager : INotifyPropertyChanged
    {
        private static LanguageManager instance;
        private ObservableCollection<Language> allLanguages = new ObservableCollection<Language>();
        public static readonly string FILE_PATH = "C:\\Users\\rilak\\source\\repos\\SR38-2021-POP2022\\SR38-2021-POP2022\\data\\txt\\languages.txt";

        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<Language> AllLanguages { get => allLanguages; set { allLanguages = value; OnPropertyChanged("allLanguages"); } }

        private LanguageManager() { }
        public static LanguageManager GetInstance()
        {
            if (instance == null) instance = new LanguageManager();
            return instance;
        }

        public Language GetLanguageById(int id)
        {

            Language language = allLanguages.ToList().Find(x => x.Id == id);
            if(language == null)
            {
                throw new LanguageNotFoundException("Language that you've been searching for isn't found");
            }
            return language;
        }

        public Language GetLanguageByName(string name)
        {

            Language language = allLanguages.ToList().Find(x => x.LanguageName == 
                name);
            if (language == null)
            {
                throw new LanguageNotFoundException("Language that you've been searching for isn't found");
            }
            return language;
        }

        public ObservableCollection<Language> GetLanguagesBasedById(string[] splittedIndexes)
        {
            ObservableCollection<Language> createdLanguages = new ObservableCollection<Language>();
            foreach (string line in splittedIndexes)
            {
                createdLanguages.Add(GetLanguageById(int.Parse(line)));
            }
            return createdLanguages;
        }

        public List<Language> GetLanguagesBasedById(int[] splittedIndexes)
        {
            List<Language> createdLanguages = new List<Language>();
            foreach (int index in splittedIndexes)
            {
                createdLanguages.Add(GetLanguageById(index));
            }
            return createdLanguages;
        }

        protected void OnPropertyChanged(String name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}
