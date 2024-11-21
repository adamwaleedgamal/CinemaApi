using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static Adam_Waleed_0522028_api.Model.Movies_M;

namespace Adam_Waleed_0522028_api.Model
{
    public class Director_M
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
}
