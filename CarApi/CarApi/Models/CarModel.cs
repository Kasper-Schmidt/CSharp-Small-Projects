namespace CarApi.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string? Brand { get; set; }
        public string? Model { get; set; }
        public int? Year { get; set; }
        public string? Color { get; set; }
        public int? Mileage { get; set; }
        public int? HorsePower { get; set; }
        public bool IsAvailable { get; set; }
        
    }
}
