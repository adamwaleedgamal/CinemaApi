using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;

namespace Adam_Waleed_0522028_api.Model
{
    public class Movies_M
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
}
