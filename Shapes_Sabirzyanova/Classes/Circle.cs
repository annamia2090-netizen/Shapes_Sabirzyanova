using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Shapes;
using System.Windows.Media;

namespace Shapes_Sabirzyanova.Classes
{
    public class Circle : Shape
    {
        public int Radius { get; set; }
        public int Diameter { get; set; }
        public Circle(int Radius, int X, int Y) : base (X, Y)
        {
            this.Radius = Radius;
            this.Diameter = Radius * 2;  
        }
        public void Draw(Canvas canvas)
        {
            Ellipse ellipse = new Ellipse();
            ellipse.Width = this.Diameter;
            ellipse.Height = this.Diameter;
            ellipse.Stroke = Brushes.HotPink;
            ellipse.StrokeThickness = 2;
            ellipse.Fill = Brushes.LightPink;
            Canvas.SetLeft(ellipse, this.X -  this.Radius);
            Canvas.SetTop(ellipse, this.Y - this.Radius);
            canvas.Children.Add(ellipse);
        }
    }
}
