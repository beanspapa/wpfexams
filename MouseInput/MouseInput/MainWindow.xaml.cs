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

namespace MouseInput
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ellipse1.MouseDown += new MouseButtonEventHandler(ellips2_MouseDown);
            ellipse1.MouseMove += new MouseEventHandler(ellips2_MouseMove);
            ellipse1.MouseUp += new MouseButtonEventHandler(ellips2_MouseUp);
            this.MouseRightButtonDown += new MouseButtonEventHandler(Window_MouseRightButtonDown);
        }

        private void Window_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            Mouse.Capture(null);
        }

        private void ellips2_MouseUp(object sender, MouseButtonEventArgs e)
        {
            label1.Content = "MouseUp" + Mouse.GetPosition(ellipse1);
        }

        private void ellips2_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Content = "MouseMove" + Mouse.GetPosition(ellipse1);
        }

        private void ellips2_MouseDown(object sender, MouseButtonEventArgs e)
        {
            label1.Content = "MouseDown";
            Mouse.Capture(ellipse1);
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (ellipse1.Fill == Brushes.Red)
                ellipse1.Fill = Brushes.Blue;
            else
                ellipse1.Fill = Brushes.Red;
        }
    }
}
