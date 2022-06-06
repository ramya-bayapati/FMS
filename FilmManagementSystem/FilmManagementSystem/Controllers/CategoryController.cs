using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FilmManagementSystem.Models;
using FilmManagementSystem.Repositories;



namespace FilmManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private CategoryRepository CategoryRepository;
        public CategoryController()
        {
            CategoryRepository = new CategoryRepository();
        }
        [HttpGet, Route("GetCategory")] //getting all category details
        public IActionResult GetCategory()
        {
            return StatusCode(200, CategoryRepository.GetCategory());
        }
        [HttpGet, Route("GetCategoryByname/{categoryname}")] //getting category deatils by categoryname
        public IActionResult GetId(string categoryname)
        {
            return StatusCode(200, CategoryRepository.GetCategorybyName(categoryname));
        }
        [HttpPost, Route("AddCategory")] // adding category details
        public IActionResult AddCategory(Category category)
        {
            CategoryRepository.AddCategory(category);
            return StatusCode(200, "record added");
        }
        [HttpPut, Route("EditCategory")] //updating category details 
        public IActionResult EditCategory(Category category)
        {
            CategoryRepository.EditCategory(category);
            return StatusCode(200, "record modified");
        }
        [HttpDelete, Route("DeleteCategory/{id}")]  //deleting category details by id
        public IActionResult DeleteCategory(string id)
        {
            CategoryRepository.DeleteCategory(id);
            return StatusCode(200, "record deleted");
        }

    }
}

