using Adam_Waleed_0522028_api.Dtos.DirectorDto;
using Adam_Waleed_0522028_api.Dtos.NationalityDto;
using Adam_Waleed_0522028_api.Repo.DirectorsRepo;
using Adam_Waleed_0522028_api.Repo.NationalityDto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Adam_Waleed_0522028_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NationalityController : ControllerBase
    {
        private readonly INationality_Repo _repo;

        public NationalityController(INationality_Repo repo)
        {
            _repo = repo;
        }

        [HttpPost("CreateNAt")]
        public IActionResult CreateNAt(Nationality_Dto dto)
        {
            try
            {
                _repo.AddDNationality(dto);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut("Put")]
        public IActionResult Put(Nationality_Dto dto, int id)
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
    }
}
