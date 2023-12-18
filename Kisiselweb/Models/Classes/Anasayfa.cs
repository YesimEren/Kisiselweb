using Microsoft.CodeAnalysis.Options;
using System.ComponentModel.DataAnnotations;

namespace Kisiselweb.Models.Classes
{
    public class Anasayfa
    {
        [Key]
        public int id { get; set; }
        public string Profiphoto { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Unvan { get; set; }
        public string Comminication { get; set; }
    }
}
