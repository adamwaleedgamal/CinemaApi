using Adam_Waleed_0522028_api.Data;
using Adam_Waleed_0522028_api.Dtos.CategoryDto;
using Adam_Waleed_0522028_api.Dtos.DirectorDto;
using Adam_Waleed_0522028_api.Model;
using Microsoft.EntityFrameworkCore;

namespace Adam_Waleed_0522028_api.Repo.CateogiryRepo
{
    //first
    //commit branch
    public class Cateogiry_Repo : ICateogiry_Repo
    {
        private readonly AppdbContext _dbContext;

        public Cateogiry_Repo(AppdbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void AddCategory(Category_Dto category_Dto)
        {
            var cat = new Category_M
            {
                Name = category_Dto.Name,
                Id = category_Dto.Id,
            };
            _dbContext.Add(cat);
            _dbContext.SaveChanges();
        }
        public void Update(Category_Update dto, int id)
        {
            var cat = _dbContext.category_ms.FirstOrDefault(x => x.Id == id);
            if (cat != null)
            {
                cat.Name += dto.Name;
            }
            _dbContext.category_ms.Update(cat);
            _dbContext.SaveChanges();
        }
    }
}
