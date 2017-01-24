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
using System.Windows.Shapes;

namespace RoutedEventTest
{
    /// <summary>
    /// Tunneling.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Tunneling : Window
    {
        public Tunneling()
        {
            InitializeComponent();
        }

        private void Window_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Console.WriteLine("1: Window");
        }

        private void Grid_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Console.WriteLine("2: Grid");
        }

        private void Button_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Console.WriteLine("3: Button");
        }

        private void Canvas_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Console.WriteLine("4: Canvas");
        }

        private void Ellipse_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Console.WriteLine("5: Ellipse");
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Console.WriteLine("Grid Mouse Down");
        }
    }
}
