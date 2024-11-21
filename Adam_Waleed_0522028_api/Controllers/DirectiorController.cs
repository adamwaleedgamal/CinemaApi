using Adam_Waleed_0522028_api.Dtos.DirectorDto;
using Adam_Waleed_0522028_api.Repo.DirectorsRepo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Adam_Waleed_0522028_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DirectiorController : ControllerBase
    {
        private readonly IDirectior_Repo _repo;

        public DirectiorController(IDirectior_Repo repo)
        {
            _repo = repo;
        }

        [HttpPost("CreateDir")]
        public IActionResult CreateDir(Director_Dto dto)
        {
            try
            {
                _repo.AddDirectior(dto);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("Put")]
        public IActionResult Put(Director_Dto_Update dto , int id)
        {
            try
            {
                _repo.Update(dto, id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        public IActionResult Delete(int id) 
        {
            try
            {
                _repo.Delete(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

    }
}
