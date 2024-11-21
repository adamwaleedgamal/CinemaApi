using Adam_Waleed_0522028_api.Dtos.DirectorDto;
using Adam_Waleed_0522028_api.Dtos.MoviesDto;

namespace Adam_Waleed_0522028_api.Repo.DirectorsRepo
{
    public interface IDirectior_Repo
    {
        public void AddDirectior(Director_Dto director_Dto);
        bool Update (Director_Dto_Update director_Dto_Update , int id);
        public void Delete(int id);

    }
}
