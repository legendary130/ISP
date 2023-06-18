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

namespace WpfApp10
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

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Canvas.Strokes.Clear();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            Kist.Color = Color.FromRgb(252, 3, 3);
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            Kist.Color = Color.FromRgb(74, 3, 252);
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            Kist.Color = Color.FromRgb(22, 22, 23);
        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            Kist.Height += 5;
            Kist.Width += 1;
        }

        private void MenuItem_Click_5(object sender, RoutedEventArgs e)
        {
            Kist.Height -= 5;
            Kist.Width -= 1;
        }
    }
}
