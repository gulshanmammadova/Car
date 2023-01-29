namespace CarModelMarka.Models
{
    public class Car
    {
        public int Id { get; set; } 
        public string Color { get; set; }
        public int Year { get; set; }
        public int MarkaId { get; set; }
        public Marka Marka { get; set; }

    }

}
