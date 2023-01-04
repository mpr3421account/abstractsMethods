using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using abstractsMethods.Entities.Enums;

namespace abstractsMethods.Entities
{
    internal abstract class Shape//devido o método Area ser abstrato, a classe também deve ser abstrata
    {
        public Color Color { get; set; }

        
        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();//Area de shape é muito genérico, portanto devemos alterar para método abstrato
    }
}
