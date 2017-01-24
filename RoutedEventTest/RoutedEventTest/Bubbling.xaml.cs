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

namespace RoutedEventTest
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            WindowBubbling.MouseRightButtonDown += new MouseButtonEventHandler(MainWindow_MouseRightButtonDown);
        }

        private void MainWindow_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Window_MouseRightButtonDown 이벤트 발생");
        }

        private void btnPuckMan_Click(object sender, RoutedEventArgs e)
        {
            string message = "#" + " Sender: " + sender.ToString() + "\r\n" + " Source: " + e.Source + "\r\n" +
                " Original Source: " + e.OriginalSource;
            lstMessages.Items.Add(message);
            lstMessages.Items.Add("버튼이 클릭 되었습니다." + "\r\n");
        }

        private void SomethingClicked(object sender, MouseButtonEventArgs e)
        {
            string message = "#" + "Sender: " + sender.ToString() + "\r\n" +
                " Source:" + e.Source + "\r\n" +
                " Original Source: " + e.OriginalSource;
            lstMessages.Items.Add(message);
            lstMessages.Items.Add("팩맨 이미지가 클릭되었습니다." + e.Handled + "\r\n");
            e.Handled = true;
        }
    }
}
