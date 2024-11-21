using Adam_Waleed_0522028_api.Dtos.MoviesDto;

namespace Adam_Waleed_0522028_api.Repo.MoviesRepo
{
    public interface IMovies_Repo
    {
           public IList<Movies_Dto> GetAll();
           public Movies_Dto_getById GetById(int id);

           public void AddMovies(Moives_Dto_Add dto);
    }
}
