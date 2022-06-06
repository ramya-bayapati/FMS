using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FilmManagementSystem.Models;
using FilmManagementSystem.Repositories;


namespace FilmManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActorController : ControllerBase
    {
        private ActorRepository ActorRepository;
        public ActorController()
        {
            ActorRepository = new ActorRepository();
        }
        [HttpGet, Route("GetActor")]
        public IActionResult GetAll() // getting actor data
        {
            return StatusCode(200, ActorRepository.GetActor());
        }
        [HttpGet, Route("GetActorByName/{firstname}")]
        public IActionResult GetActorname(string firstname) // getting data by firstname
        {
            return StatusCode(200, ActorRepository.GetActorName(firstname));
        }
        [HttpGet, Route("GetActorById/{id}")]
        public IActionResult GetActorId(string id) //getting data by id
        {
            return StatusCode(200, ActorRepository.GetActorid(id));
        }
        [HttpPost, Route("GetAlldetails")] // adding actor details
        public IActionResult GetActor(Actor actor)
        {
            ActorRepository.AddActor(actor);
            return StatusCode(200, "record added");
        }
        [HttpPut, Route("EditActor")] //updating actor details
        public IActionResult EditActor(Actor actor)
        {
            ActorRepository.EditActor(actor);
            return StatusCode(200, "record modified");
        }
        [HttpDelete, Route("DeletecategoryId/{id}")] //deleting actor details by id
        public IActionResult DeleteCategory(string id)
        {
            ActorRepository.DeleteActor(id);
            return StatusCode(200, "record deleted");
        }


    }
}

