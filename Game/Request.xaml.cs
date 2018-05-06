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
    /// Interaction logic for Request.xaml
    /// </summary>
    public partial class Request : Window
    {
        public string t;
        public string check;
        public Request()
        {
            InitializeComponent();
        }

        public void Check_me(string str)
        {
            t= str;
            lb.Content = t;
        }
        
        private void Click_Yes(object sender, RoutedEventArgs e)
        {
            if(check == "easy")
            {
                MainWindow MainWindow = new MainWindow();
                MainWindow.Show();
                Game.MainWindow a = new MainWindow();
            }
            else if(check == "medium")
            {
                MainWindow2 MainWindow2 = new MainWindow2();
                MainWindow2.Show();
                Game.MainWindow2 a = new MainWindow2();
            }
            else if(check == "hard")
            {
                MainWindow3 MainWindow3 = new MainWindow3();
                MainWindow3.Show();
                Game.MainWindow3 a = new MainWindow3();
            }
            this.Close();
        }

        private void Click_No(object sender, RoutedEventArgs e)
        {
            MainPage MainPage = new MainPage();
            MainPage.Show();
            Game.MainWindow a = new MainWindow();
            lb.Content = a.time.ToString();
            this.Close();
        }
    }
}
