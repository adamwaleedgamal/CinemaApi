using Adam_Waleed_0522028_api.Data;
using Adam_Waleed_0522028_api.Dtos.CategoryDto;
using Adam_Waleed_0522028_api.Dtos.DirectorDto;
using Adam_Waleed_0522028_api.Dtos.MoviesDto;
using Adam_Waleed_0522028_api.Model;
using Microsoft.EntityFrameworkCore;

namespace Adam_Waleed_0522028_api.Repo.MoviesRepo
{
    public class Moivies_Repo : IMovies_Repo
    {
        private readonly AppdbContext appdbContext;

        public Moivies_Repo(AppdbContext appdbContext)
        {
            this.appdbContext = appdbContext;
        }
        public void AddMovies(Moives_Dto_Add dto)
        {
            var mov = appdbContext.movies_Ms.FirstOrDefault(x => x.Id == dto.Id);
            if (mov == null)
            {
                throw new Exception("");
            }
            Category_M cat = new Category_M
            {
                Id = mov.CategoryId,

            };
            appdbContext.category_ms.Add(cat);
            appdbContext.SaveChanges();
        }

        public IList<Movies_Dto> GetAll()
        {
            var res = appdbContext.movies_Ms.Select(x => new Movies_Dto
            {
                Title = x.Title,
                ReleaseYear = x.ReleaseYear,    
            }).ToList();
            return res;
        }

        public Movies_Dto_getById GetById(int id)
        {
            var mov = appdbContext.movies_Ms.FirstOrDefault(x => x.Id == id);
            if (mov == null)
            {
                throw new Exception("Credit Not Found");
            }
            return new Movies_Dto_getById
            {
             Title = mov.Title,    
            };
        }
    }
    }
