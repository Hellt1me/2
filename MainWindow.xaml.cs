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
using System.Windows.Threading;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            statusTextBlock.Text = "Приложение запущено";

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
                mi_open.Background = Brushes.Aquamarine;
            statusTextBlock.Text = "Фон сменен";
        }


        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Чембарских В.А");
            statusTextBlock.Text = "Данные выведены";
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void MenuItem_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            mi_open.Background = Brushes.White;
        }

        private void MenuItem_MouseEnter(object sender, MouseEventArgs e)
        {
            statusTextBlock.Text = "Элемент меню";
        }

        private void MenuItem_MouseLeave(object sender, MouseEventArgs e)
        {
            statusTextBlock.Text = " ";
        }

        private void MenuItem_MouseEnter_1(object sender, MouseEventArgs e)
        {
            statusTextBlock.Text = "Элемент меню";
        }

        private void MenuItem_MouseLeave_1(object sender, MouseEventArgs e)
        {
            statusTextBlock.Text = " ";
        }

        private void MenuItem_MouseEnter_2(object sender, MouseEventArgs e)
        {
            statusTextBlock.Text = "Элемент меню";
        }

        private void MenuItem_MouseLeave_2(object sender, MouseEventArgs e)
        {
            statusTextBlock.Text = " ";
        }
    }
}
