﻿using System;
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

namespace ResourceTest
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

        private void btnNormal_Click(object sender, RoutedEventArgs e)
        {
            label1.Style = null;
        }

        private void btnRes1_Click(object sender, RoutedEventArgs e)
        {
            label1.Style = (Style)FindResource("LabelStyle1");
        }

        private void btnRes2_Click(object sender, RoutedEventArgs e)
        {
            label1.Style = (Style)FindResource("LabelStyle2");
        }
    }
}
