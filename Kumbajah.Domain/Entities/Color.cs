using System.Collections.Generic;

namespace Kumbajah.Domain.Entities
{
    public class Color
    {
        public int Id { get; set; }
        public string ColorName { get; set; }
        public virtual List<Product> Products { get; set; }

        public Color() { }

        public Color(string colorName)
        {
            ColorName = colorName;
        }
    }
}
