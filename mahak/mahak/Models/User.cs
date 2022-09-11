using System.Net.NetworkInformation;

namespace mahak.Models
{
    public class User
    {
        public int Id { get; set; }
        public int RegisterId { get; set; }
        public Register? Register { get; set; }

    }
}
