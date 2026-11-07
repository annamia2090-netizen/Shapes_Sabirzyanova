using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes_Sabirzyanova.Classes
{
    public class Shape
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Shape(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }
    }
}
