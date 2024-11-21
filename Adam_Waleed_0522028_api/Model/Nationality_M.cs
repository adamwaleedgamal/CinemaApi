using System.ComponentModel.DataAnnotations.Schema;
using System.IO;

namespace Adam_Waleed_0522028_api.Model
{
    public class Nationality_M
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DirectoirId { get; set; }
        public Director_M Director { get; set; }
    }
}
