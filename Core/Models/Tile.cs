using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Models
{
    public class Tile
    {
        public int Id { get; set; }          // Feltets nummer (1, 2, 3...)
        public string Title { get; set; } = ""; // Overskrift (f.eks. "3 SUG")
        public string Description { get; set; } = ""; // Ekstra info (f.eks. "12 SEK")
        public string Color { get; set; } = "#ffffff"; // Baggrundsfarve
        public TileType Type { get; set; } = TileType.Normal;
    }

    public enum TileType
    {
        Normal,
        Start,
        Slut,
        Special // Bruges til f.eks. "Slå tilbage" eller "Ninja" ikonerne
    }
}
