using System.Collections.Generic;

namespace Kumbajah.Domain.Entities
{
    public class Color
    {
        public short Id { get; set; }
        public string ColorName { get; set; }
        public virtual IEnumerable<Product> Products { get; private set; }

        public Color() { }

        public Color(string colorName)
        {
            ColorName = colorName;
        }
    }
}
