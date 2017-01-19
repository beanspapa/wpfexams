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

namespace AnimationTest
{
    /// <summary>
    /// _2Dgraphic.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class _2Dgraphic : Window
    {
        public _2Dgraphic()
        {
            InitializeComponent();
        }

        private void Ellipse_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("A simple Ellipse. Was MouseLeftButtonDown clicked!");
        }
    }
}
