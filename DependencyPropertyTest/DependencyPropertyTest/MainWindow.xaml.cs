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

namespace DependencyPropertyTest
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnChange_Click(object sender, RoutedEventArgs e)
        {
            UserText = textBox1.Text;
        }

        public static readonly DependencyProperty UserProperty = DependencyProperty.Register(
            "TextChange",
            typeof(String),
            typeof(MainWindow),
            new FrameworkPropertyMetadata(new PropertyChangedCallback(OnTextChangePropertyChanged)));

        private static void OnTextChangePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            MainWindow userNamecontrol = d as MainWindow;
            string newText = (string)e.NewValue;
            string oldText = (string)e.OldValue;

            userNamecontrol.txtNewText.Text = newText;
            userNamecontrol.txtOldText.Text = oldText;
        }

        public String UserText
        {
            get { return (String)GetValue(UserProperty); }
            set { SetValue(UserProperty, value); }
        }
    }
}
