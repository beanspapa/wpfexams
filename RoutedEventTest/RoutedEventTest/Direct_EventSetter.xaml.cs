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
    /// Direct_EventSetter.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Direct_EventSetter : Window
    {
        public Direct_EventSetter()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            e.Handled = true;
        }

        private void btnSetColor(object sender, RoutedEventArgs e)
        {
            Button b = e.Source as Button;
            b.Background = new SolidColorBrush(Colors.Red);
        }
    }
}
