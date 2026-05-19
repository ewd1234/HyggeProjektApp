using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Models
{
    public class Player
    {
        public string Name { get; set; } = "";
        public string Color { get; set; } = "#ffffff"; // Standard hvid
        public int Position { get; set; } = 0; // Alle starter på 0 (START)
    }
}
