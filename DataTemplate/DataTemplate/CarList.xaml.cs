using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace DataTemplate
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class CarList : Window
    {
        public void Car(string comp, string name)
        {
            this.Company = comp;
            this.CarName = name;
        }

        string company = string.Empty;
        public string Company
        {
            get { return company; }
            set
            {
                company = value;
            }
        }

        string carName = string.Empty;
        public string CarName
        {
            get { return carName; }
            set
            {
                carName = value;
            }
        }
    }

    public class Cars : ObservableCollection<CarList> { }
}
