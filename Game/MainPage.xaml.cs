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

namespace Game
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Window
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void easy_Click(object sender, RoutedEventArgs e)
        {
            MainWindow MainWindow = new MainWindow();
            MainWindow.Show();
            this.Close();
        }

        private void midium_Click(object sender, RoutedEventArgs e)
        {
            MainWindow2 MainWindow2 = new MainWindow2();
            MainWindow2.Show();
            this.Close();
        }

        private void hard_Click(object sender, RoutedEventArgs e)
        {
            MainWindow3 MainWindow3 = new MainWindow3();
            MainWindow3.Show();
            this.Close();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void Hide_Click(object sender, RoutedEventArgs e)
        {
            foreach (Window wnd in Application.Current.Windows)
            {
                wnd.WindowState = WindowState.Minimized;
            }
        }
    }
}
