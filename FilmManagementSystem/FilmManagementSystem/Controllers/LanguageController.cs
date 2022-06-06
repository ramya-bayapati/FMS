using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FilmManagementSystem.Models;
using FilmManagementSystem.Repositories;

namespace FilmManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LanguageController : ControllerBase
    {
        private LanguageRepository LanguageRepository;
        public LanguageController()
        {
            LanguageRepository = new LanguageRepository();
        }
        [HttpGet, Route("GetLanguage")]  // getting language details
        public IActionResult GetLanguage()
        {
            return StatusCode(200, LanguageRepository.GetLanguage());
        }
        [HttpGet, Route("GetLanguageByname/{languagename}")] //getting language details by language name
        public IActionResult GetId(string languagename)
        {
            return StatusCode(200, LanguageRepository.GetLanguagebyName(languagename));
        }
        [HttpPost, Route("AddLanguage")] //adding language details
        public IActionResult AddLanguage(Language language)
        {
            LanguageRepository.AddLanguage(language);
            return StatusCode(200, "record added");
        }
        [HttpPut, Route("EditLanguage")] //updating language details
        public IActionResult EditLanguage(Language language)
        {
            LanguageRepository.EditLanguage(language);
            return StatusCode(200, "record modified");
        }
        [HttpDelete, Route("DeleteLanguage/{id}")] //deleting language details by using id
        public IActionResult DeleteCategory(string id)
        {
            LanguageRepository.DeleteLanguage(id);
            return StatusCode(200, "record deleted");
        }
    }
}

