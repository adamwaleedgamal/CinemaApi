using Adam_Waleed_0522028_api.Dtos.CategoryDto;
using Adam_Waleed_0522028_api.Dtos.DirectorDto;

namespace Adam_Waleed_0522028_api.Repo.CateogiryRepo
{
    public interface ICateogiry_Repo
    {
        public void AddCategory(Category_Dto category_Dto);
        public void Update(Category_Update dto, int id);
    }
}
