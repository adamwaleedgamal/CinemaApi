using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static Adam_Waleed_0522028_api.Model.Movies_M;
using System;
using Adam_Waleed_0522028_api.Model;
using Adam_Waleed_0522028_api.Dtos.MoviesDto;
using Adam_Waleed_0522028_api.Repo.MoviesRepo;

namespace Adam_Waleed_0522028_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {

        private readonly IMovies_Repo _repo;

        public MoviesController(IMovies_Repo repo)
        {
            _repo = repo;
        }

        [HttpGet("GetAllDir")]
        public IActionResult GetAllDir()
        {
            try
            {
                var res = _repo.GetAll();
                return Ok(res);
            }
            catch (Exception ex)
            {
                return NotFound("Not Found Credits");
            }
        }
      
        [HttpGet("GetBookById")]
        public IActionResult GetBookById(int id)
        {
            try
            {
                var res = _repo.GetById(id);
                return Ok(res);
            }
            catch (Exception ex)
            {
                return NotFound("Credit Not Found");
            }
        }

        [HttpPost("CreateMoivies")]
        public IActionResult CreateMoivies(Moives_Dto_Add dto)
        {
            try
            {
                _repo.AddMovies(dto);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}

