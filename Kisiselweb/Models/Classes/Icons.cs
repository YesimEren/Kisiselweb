﻿using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace Kisiselweb.Models.Classes
{
    public class Icons
    {
        [Key]
        public int İd { get; set; }
        public string Icon { get; set; }
        public string Link { get; set; }
    }
}
