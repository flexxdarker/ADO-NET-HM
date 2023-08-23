using System.Data;

namespace UserClass
{
    public class Guests
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Adress { get; set; }
        public int Phone { get; set; }
        public int RoleId { get; set; }
    }
}