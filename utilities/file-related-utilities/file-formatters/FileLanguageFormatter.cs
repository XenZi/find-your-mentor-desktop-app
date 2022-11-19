using SR38_2021_POP2022.resources.managers;
using SR38_2021_POP2022.resources.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR38_2021_POP2022.utilities.file_related_utilities
{
    class FileLanguageFormatter
    {

        public static Language CreateLanguageFromFile(string[] splittedLine)
        {
            Language language = new Language();
            language.Id = int.Parse(splittedLine[0]);
            language.LanguageName = splittedLine[1];
            language.Active = Boolean.Parse(splittedLine[2]);
            return language;
        }

        public static string CreateStringFormatForFileStorage(Language language)
        {
            return String.Format("{0}|{1}|{2}", language.Id, language.LanguageName, language.Active);
        }

        public static string CreateStringRepresentationOfLanguageIDs(List<Language> languages)
        {
            StringBuilder buildedString = new StringBuilder();
            for (int i = 0; i < languages.Count; i++)
            {
                if (i == languages.Count - 1)
                {
                    buildedString.Append(languages[i].Id);
                }
                else
                {
                    buildedString.Append(languages[i].Id + ",");
                }
            }
            return buildedString.ToString();
        }

        public static string[] SplitLanguagesFromFile(string line)
        {
            string[] splittedAddresses = line.Split(',');
            return splittedAddresses;
        }

    }
}
