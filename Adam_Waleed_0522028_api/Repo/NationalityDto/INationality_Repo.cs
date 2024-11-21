using Adam_Waleed_0522028_api.Dtos.DirectorDto;
using Adam_Waleed_0522028_api.Dtos.NationalityDto;

namespace Adam_Waleed_0522028_api.Repo.NationalityDto
{
    public interface INationality_Repo
    {
        public void AddDNationality(Nationality_Dto nationalityDto);
        bool Update(Nationality_Dto nationality_Dto_update, int id);
    }
}
