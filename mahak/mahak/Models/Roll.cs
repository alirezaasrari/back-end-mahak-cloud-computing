namespace mahak.Models
{
    public class Roll
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int? UserId { get; set; }
        public User? User { get; set; }
    }
}
