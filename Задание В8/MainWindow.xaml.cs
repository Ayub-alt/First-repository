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

namespace Задание_В8
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

        private void but_count_MouseEnter(object sender, MouseEventArgs e)
        {
            but_count.Background = Brushes.Red;
        }

        private void but_count_MouseLeave(object sender, MouseEventArgs e)
        {
            but_count.Background = Brushes.GreenYellow;
        }
        public void count()
        {
            int sec = Int32.Parse(txttime.Text);
            double d = sec / 3600;
            string str = Convert.ToString(Math.Floor(d));
            answer.Text = d.ToString();

        }

        private void but_count_Click(object sender, RoutedEventArgs e)
        {
            count();
        }
    }
}
