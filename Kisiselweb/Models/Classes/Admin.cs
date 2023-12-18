using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace Kisiselweb.Models.Classes
{
    public class Admin
    {
        [Key]
        public int id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
