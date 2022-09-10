namespace mahak.Models
{
    public class Register
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public string Family { get; set; } = String.Empty;
        public string Email { get; set; } = String.Empty;
        public int Password { get; set; }
        public int Phone { get; set; }
        public string NationalCode { get; set; } = String.Empty;
        public string picture { get; set; } = String.Empty;
    }
}
