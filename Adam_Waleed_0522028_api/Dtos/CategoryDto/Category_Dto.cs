using Adam_Waleed_0522028_api.Model;

namespace Adam_Waleed_0522028_api.Dtos.CategoryDto
{
    public class Category_Dto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<Movies_M> Movies { get; set; }
    }
    public class Category_Update
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<Movies_M> Movies { get; set; }


    }
}
