using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FilmManagementSystem.Models;
using FilmManagementSystem.Repositories;

namespace FilmManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmController : ControllerBase
    {
        private FilmRepository FilmRepository;
        public FilmController()
        {
            FilmRepository = new FilmRepository();
        }
        [HttpGet, Route("GetAllFilm")] //get all film data
        public IActionResult GetAll()
        {
            return StatusCode(200, FilmRepository.GetFilm());
        }
        [HttpGet, Route("GetFilmByTitle/title")] //get all film data by title
        public IActionResult GetFilmTitle(string title)
        {
            return StatusCode(200, FilmRepository.GetFilmTitle(title));
        }
        [HttpGet, Route("GetFilmByReleaseyear/releaseYear")] //get all film data by releaseyear
        public IActionResult GetFilmreleaseYear(int releaseYear)
        {
            return StatusCode(200, FilmRepository.GetFilmReleaseYear(releaseYear));
        }
        [HttpGet, Route("GetFilmByRating/rating")] //get all film data by rating
        public IActionResult GetFilmrating(decimal rating)
        {
            return StatusCode(200, FilmRepository.GetFilmRating(rating));
        }
        [HttpGet, Route("GetFilmByActorId/{actorid}")] //get all film data by actorid
        public IActionResult GetFilmActorId(string actorid)
        {
            return StatusCode(200, FilmRepository.GetFilmActorId(actorid));
        }
        [HttpGet, Route("GetFilmByCategoryId/{categoryid}")] //get all film data by categoryid
        public IActionResult GetFilmCategoryId(string categoryid)
        {
            return StatusCode(200, FilmRepository.GetFilmCategoryId(categoryid));
        }
        [HttpGet, Route("GetFilmByLanguageId/{languageid}")] //get all film data by langaugeid
        public IActionResult GetFilmLanguageId(string languageid)
        {
           return StatusCode(200, FilmRepository.GetFilmLanguageId(languageid));
        }


        [HttpPost, Route("AddFilm")] // add film data
        public IActionResult Add(Film film)
        {
            FilmRepository.AddFilm(film);
            return StatusCode(200, "Record Added");
        }
        [HttpPut, Route("UpdateFilm")] //update film data
        public IActionResult Edit(Film film)
        {
            FilmRepository.EditFilm(film);
            return StatusCode(200, "Modified");
        }
        [HttpDelete, Route("DeleteFilmById/id")]  //delete film data by id
        public IActionResult DeleteFilmTitle(int id)
        {
            FilmRepository.DeleteFilm(id);
            return StatusCode(200, "record deleted");
        }

    }
}
