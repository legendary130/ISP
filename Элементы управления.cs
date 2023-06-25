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

namespace WpfApp2
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double k = Convert.ToDouble(TextBox1.Text);
            double n = Convert.ToDouble(TextBox2.Text);
            double p = Convert.ToDouble(TextBox3.Text);
            double y = Convert.ToDouble(TextBox4.Text);
            double result = 0;
            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j < k; j++)
                {
                    result += Math.Pow(p, i) * Math.Pow(y, j) / (i * j);

                }
            }           
            this.Title = "Ответ= "+result;
        }
    }
}
