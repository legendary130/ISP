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

namespace WpfApp6
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
            Grid1.Background = new SolidColorBrush(Colors.Red);
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            Grid1.Background = new SolidColorBrush(Colors.Blue);
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            Grid1.Background = new SolidColorBrush(Colors.Black);
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Мой создатель Захар Быстрянцев");
        }

        private void MenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            TextBlock1.Text = "Эта кнопка перекрашивает фон в красный";
        }

        private void MenuItem_MouseMove_1(object sender, MouseEventArgs e)
        {
            TextBlock1.Text = "Эта кнопка перекрашивает фон в синий";
        }

        private void MenuItem_MouseMove_2(object sender, MouseEventArgs e)
        {
            TextBlock1.Text = "Эта кнопка перекрашивает фон в чёрный";
        }

        private void MenuItem_MouseMove_3(object sender, MouseEventArgs e)
        {
            TextBlock1.Text = "Эта кнопка выводит ФИ разработчика";
        }
        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItem_Click_5(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItem_Click_6(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItem_Click_7(object sender, RoutedEventArgs e)
        {

        }
    }
}
