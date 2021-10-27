using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using RentalMovie.Business.Abstract;
using RentalMovie.Entities.Concrete;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        IMovieService _movieService;
        public MoviesController(IMovieService movieService, IWebHostEnvironment webHostEnvironment)
        {
            _movieService = movieService;
            
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _movieService.GetAll();
            if(result.Success)
            { return Ok(result);  }
            return BadRequest(result);
        
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _movieService.GetById(id);
            if (result.Success)
            { return Ok(result.Data); }
            return BadRequest(result);

        }
        [HttpGet("getmoviedetails")]
        public IActionResult GetCarDetails()
        {
            var result = _movieService.GetMovieDetails();
            if (result.Success)
            { return Ok(result); }
            return BadRequest(result);

        }

        [HttpGet("getmoviesbycategoryid")]
        public IActionResult GetCarDetails(int id)
        {
            var result = _movieService.GetMoviesByCategoryId(id);
            if (result.Success)
            { return Ok(result.Data); }
            return BadRequest(result);

        }
      
        [HttpPost("add")]
        public IActionResult Add(Movie movie)
        {
            var result = _movieService.Add(movie);
            if (result.Success)
            { return Ok(result); }
            return BadRequest(result);

        }
        [HttpPost("delete")]
        public IActionResult Delete(Movie movie)
        {
            var result = _movieService.Delete(movie);
            if (result.Success)
            { return Ok(result); }
            return BadRequest(result);

        }
        [HttpPost("update")]
        public IActionResult Update(Movie movie)
        {
            var result = _movieService.Update(movie);
            if (result.Success)
            { return Ok(result); }
            return BadRequest(result);

        }


    }
}
