using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Shapes_Sabirzyanova.Classes;

namespace Shapes_Sabirzyanova
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void DrawCircle_Click(object sender, RoutedEventArgs e)
        {
            Circle circle = new Circle(50,50,90);
            circle.Draw(Canvas);
        }

        private void DrawTriangle_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
