using Adam_Waleed_0522028_api.Dtos.CategoryDto;
using Adam_Waleed_0522028_api.Dtos.DirectorDto;
using Adam_Waleed_0522028_api.Repo.CateogiryRepo;
using Adam_Waleed_0522028_api.Repo.DirectorsRepo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Adam_Waleed_0522028_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CateogryController : ControllerBase
    {
        private readonly ICateogiry_Repo _repo;

        public CateogryController(ICateogiry_Repo repo)
        {
            _repo = repo;
        }

        [HttpPost("CreateDCat")]
        public IActionResult CreateDCat(Category_Dto dto)
        {
            try
            {
                _repo.AddCategory(dto);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut("Put")]
        public IActionResult Put(Category_Update dto, int id)
        {
            _repo.Update(dto, id);
            return Ok();
        }
    }
}
