using Adam_Waleed_0522028_api.Model;
using System.ComponentModel.DataAnnotations;

namespace Adam_Waleed_0522028_api.Dtos.MoviesDto
{
    public class Movies_Dto
    {
        public int Id { get; set; }

        [Required]

        public string Title { get; set; }
        [Required]
        public DateTime ReleaseYear { get; set; }

        public int CategoryId { get; set; }
        public Category_M Category { get; set; }
        public IList<Movies_M> Directors { get; set; }
    }

    public class Movies_Dto_getById
    {
        [Required]
        public string Title { get; set; }
    }

    public class Moives_Dto_Add
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public DateTime ReleaseYear { get; set; }
    }
}
