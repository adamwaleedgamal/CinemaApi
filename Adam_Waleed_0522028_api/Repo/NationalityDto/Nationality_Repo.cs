using Adam_Waleed_0522028_api.Data;
using Adam_Waleed_0522028_api.Dtos.DirectorDto;
using Adam_Waleed_0522028_api.Dtos.NationalityDto;
using Adam_Waleed_0522028_api.Model;
using Microsoft.EntityFrameworkCore;

namespace Adam_Waleed_0522028_api.Repo.NationalityDto
{
    public class Nationality_Repo : INationality_Repo
    {
        private readonly AppdbContext _appdbcontext;

        public void AddDNationality(Nationality_Dto nationalityDto)
        {
            var nat = new Nationality_M
            {
              Id = nationalityDto.Id,
              Name = nationalityDto.Name,
            };
            _appdbcontext.Add(nat);
            _appdbcontext.SaveChanges();
        }

     

        public bool Update(Nationality_Dto nationality_Dto_update, int id)
        {

            var nat = _appdbcontext.nationality_ms.Find(id);
            if (nat == null)
                return false;
                    nat.Name = nationality_Dto_update.Name;
            nat.Id = id;

            _appdbcontext.Update(nat);
            _appdbcontext.SaveChanges();
            return true;
        }
    }
}
