using FilmManagementSystem.Models;
using System.Collections.Generic;
using System.Linq;
using System;

namespace FilmManagementSystem.Repositories
{
    public class LanguageRepository
    {
        private readonly FilmDataBaseContext context;
        public LanguageRepository()
        {
            context = new FilmDataBaseContext();
        }
        public void AddLanguage(Language language) // add language details
        {
            context.Languages.Add(language);
            context.SaveChanges();
        }
        public List<Language> GetLanguage() // getting all language data
        {
            return context.Languages.ToList();
        }
        public Language GetLanguagebyName(string languagename) // getting language details by language name
        {
            Language language = context.Languages.SingleOrDefault(s => s.LanguageName == languagename);
            return language;
        }
        public void EditLanguage(Language language)// updating language data
        {
            context.Languages.Update(language);
            context.SaveChanges();
        }
        public void DeleteLanguage(string id) // deleting data by id
        {
            Language language = context.Languages.Find(id);
            context.Languages.Remove(language);
            context.SaveChanges();
        }
    }
}
