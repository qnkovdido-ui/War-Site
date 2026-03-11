namespace Nazi.Models
{
    public class AirPlane
    {
        public int id { get; set; }
        public string? brand { get; set; }
        public string? model { get; set; }
        public double Maxspeed { get; set; }
        public DateTime FirstFlightSate { get; set; }
        public bool IsActive { get; set; } = true;
        public string? ImageUrl { get; set; }
    }
}
