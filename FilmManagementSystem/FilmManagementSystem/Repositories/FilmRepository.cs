using FilmManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FilmManagementSystem.Repositories
{
       public class FilmRepository
       {   
            private readonly FilmDataBaseContext context;
            public FilmRepository()
            {
                context = new FilmDataBaseContext();
            }
            public void AddFilm(Film film) //Add new row details to film table
            {
                context.Films.Add(film);
                context.SaveChanges();
            }

            public List<Film> GetFilm() // return list of Film
            {
                return context.Films.ToList();
            }
            public Film GetFilmTitle(string title) //Get Film details using title
            {
                Film film = context.Films.SingleOrDefault(s => s.Title == title);
                return film;
            }
            public List<Film> GetFilmReleaseYear(int releaseYear) //Get Film by using releaseyear
            {
                List<Film> films = context.Films.Where(i => i.ReleaseYear == releaseYear).ToList();
                return films;

            }
            public List<Film> GetFilmRating(decimal rating) //Get Film by using Rating
            {

                List<Film> films = context.Films.Where(f => f.Rating == rating).ToList();
                return films;
            }
            public List<Film> GetFilmActorId(string actorid)
            {
                List<Film> films = context.Films.Where(s => s.ActorId == actorid).ToList();
                return films;
            }
            public List<Film> GetFilmCategoryId(string categoryid)
            {
                List<Film> films = context.Films.Where(c => c.CategoryId == categoryid).ToList();
                return films;
            }
            public List<Film> GetFilmLanguageId(string languageid)
            {
                List<Film> films = context.Films.Where(s => s.LanguageId == languageid).ToList();
                return films;
            }
            public void EditFilm(Film film)  // modifying film data 
            {
                context.Films.Update(film);
                context.SaveChanges();
            }
            public void DeleteFilm(int id) //deleting film data by id
            {
                Film film = context.Films.Find(id);
                context.Remove(film);
                context.SaveChanges();

            }


       }
    
}
