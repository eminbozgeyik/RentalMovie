using Microsoft.AspNetCore.Mvc;
using RentalMovie.Business.Abstract;
using RentalMovie.Entities.Concrete;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _categoryService.GetAll();
            if (result.Success)
            { return Ok(result); }
            return BadRequest(result);

        }

        [HttpGet("getbycategoryname")]
        public IActionResult GetByCategoryName(string name)
        {
            var result = _categoryService.GetByCategoryName(name);
            if (result.Success)
            { return Ok(result.Data); }
            return BadRequest(result);

        }

        [HttpGet("getbyid")]
        public IActionResult GetByid(int id)
        {
            var result = _categoryService.GetById(id);
            if (result.Success)
            { return Ok(result.Data); }
            return BadRequest(result);

        }

        [HttpPost("add")]
        public IActionResult Add(Category category)
        {
            var result = _categoryService.Add(category);
            if (result.Success)
            { return Ok(result); }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Category category)
        {
            var result = _categoryService.Update(category);
            if (result.Success)
            { return Ok(result); }
            return BadRequest(result);

        }
        [HttpPost("delete")]
        public IActionResult Delete(Category category)
        {
            var result = _categoryService.Delete(category);
            if (result.Success)
            { return Ok(result); }
            return BadRequest(result);

        }
    }
}
