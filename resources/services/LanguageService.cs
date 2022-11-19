using SR38_2021_POP2022.resources.dao;
using SR38_2021_POP2022.resources.managers;
using SR38_2021_POP2022.resources.models;
using SR38_2021_POP2022.utilities.exceptions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR38_2021_POP2022.resources.services
{
    class LanguageService
    {
        LanguageRepository repository = null;

        public LanguageService()
        {
            repository = new LanguageRepository();
        }

        public void InitializeService()
        {
            FillModelManager();
        }

        private void FillModelManager()
        {
            repository.Read();
        }
        

        public ObservableCollection<Language> GetAllLanguages()
        {
            try
            {
                ObservableCollection<Language> languages = new ObservableCollection<Language>(LanguageManager.GetInstance().AllLanguages.Where(ad => ad.Active).ToList());
                return languages;
            }
            catch (AddressNotFoundException exception)
            {
                return new ObservableCollection<Language>();
            }
        }
        public void CreateLanguage( string languageName)
        {
            repository.Create(languageName);
        }

        public void UpdateLanguage(int id, string languageName)
        {
            repository.Update(id, languageName);
        }

        public void DeleteLanguage(int id)
        {
            repository.Delete(id);
        }
    }
}
