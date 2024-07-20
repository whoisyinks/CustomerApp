namespace CustomerApp.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public DateTime SignupInfo { get; set; }
        public string? SwimTarrif { get; set; }
        public decimal Price { get; set; }
    }
}
