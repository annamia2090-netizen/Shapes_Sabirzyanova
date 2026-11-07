using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Shapes_Sabirzyanova.Classes
{
    public class Triangle : Shape
    {
        public int X1 { get; set; }
        public int Y1 { get; set; }
        public int X2 { get; set; }
        public int Y2 { get; set; }
        public int X3 { get; set; }
        public int Y3 { get; set; }
        public Triangle(int X1, int Y1, int X2, int Y2, int X3, int Y3) : base (X1, Y1)
        {
            this.X1 = X1;
            this.Y1 = Y1;   
            this.X2 = X2;
            this.Y2 = Y2;
            this.X3 = X3;
            this.Y3 = Y3;
        }
        public void Draw(Canvas canvas)
        {
            Polygon polygon = new Polygon();
            polygon.Stroke = Brushes.HotPink;
            polygon.StrokeThickness = 2;
            polygon.Fill = Brushes.LightPink;
            Point p1 = new Point(this.X1, this.Y1);
            Point p2 = new Point(this.X2, this.Y2);
            Point p3 = new Point(this.X3, this.Y3);
            polygon.Points.Add(p1);
            polygon.Points.Add(p2);
            polygon.Points.Add(p3);
            canvas.Children.Add(polygon);
        }
    }
}
