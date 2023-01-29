namespace CarModelMarka.Models
{
    public class Marka
    {
        public int Id { get; set; }
        public string? MarkaName { get; set; }
        public int ModelId { get; set; }
        public Model Model { get; set; }
    }
}
