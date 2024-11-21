using Adam_Waleed_0522028_api.Model;
using System.ComponentModel.DataAnnotations;

namespace Adam_Waleed_0522028_api.Dtos.DirectorDto
{
    public class Director_Dto
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Phone]
        public string Contact { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public int NationalityId { get; set; }
        public Nationality_M Nationality { get; set; }
        public IList<Movies_M> Movies { get; set; }
    }
    public class Director_Dto_Update
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Phone]
        public string Contact { get; set; }
        [EmailAddress]
        public string Email { get; set; }
    }
}
