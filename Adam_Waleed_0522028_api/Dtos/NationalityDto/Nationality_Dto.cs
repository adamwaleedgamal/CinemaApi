using Adam_Waleed_0522028_api.Model;

namespace Adam_Waleed_0522028_api.Dtos.NationalityDto
{
    public class Nationality_Dto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DirectoirId { get; set; }
        public Director_M Director { get; set; }
    }
    public class Nationlaty_Delete
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
