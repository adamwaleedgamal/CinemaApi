using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static Adam_Waleed_0522028_api.Model.Movies_M;

namespace Adam_Waleed_0522028_api.Model
{
    public class Category_M
    {
            public int Id { get; set; }
            public string Name { get; set; }
            public IList<Movies_M> Movies { get; set; }
    }
}
