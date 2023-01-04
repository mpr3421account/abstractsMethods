using abstractsMethods.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractsMethods.Entities
{
    internal class Rectangle : Shape
    {
        public Rectangle(Color color, double width, double height) : base(color)
        {
            Width = width;
            Height = height;
        }

        public double Width { get; set; }
        public double Height { get; set; }


        public override double Area()
        {
            throw new NotImplementedException();
        }
    }
}
