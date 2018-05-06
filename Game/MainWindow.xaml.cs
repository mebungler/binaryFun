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
using System;

namespace Game
{
    public partial class MainWindow : Window
    {
        DispatcherTimer _timer;
        TimeSpan _time;

        public MainWindow()
        {      

            InitializeComponent();
            fillRandomly();
            fillCheckers();
            fillZeros();
            checkTable();
            d_time();
                  
        }
        public TimeSpan time;

        public void d_time()
        {
         _time = TimeSpan.FromSeconds(0);

            _timer = new DispatcherTimer(TimeSpan.FromMilliseconds(15), DispatcherPriority.Normal, delegate
            {
                tbTime.Text = _time.ToString("c");
                if (row && col) {
                    time = _time;
                    _timer.Stop();
                }
                _time = _time.Add(TimeSpan.FromSeconds(+1));
            }, Application.Current.Dispatcher);

            _timer.Start();
        }
        
        private void GameOver()
        {
            
           string str = _time.ToString();
           Request Request = new Request();
           Request.Check_me(str);
           Request.Show();
           Request.check = "easy";
           this.Close();
            /*
                if (MessageBox.Show("You have won", "GAME OVER", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes) 
                {
                    MainWindow MainWindow = new MainWindow();
                    MainWindow.Show();
                    this.Close();
                }
                else
                {
                    MainPage MainPage = new MainPage();
                    MainPage.Show();
                    this.Close();
                }*/
                
        }

        private void fillRandomly()
        {
            Random random = new Random();
            for (int i = 0; i < 19; i++)
            {
                if ((i + 1) % 5 != 0)
                    (container.Children[i] as Button).Content = random.Next(0, 2).ToString();
            }
        }

        static int[] randomize(int dimen)
        {
            int max = (int)Math.Pow(2, dimen);

            int[] src = new int[max - 2];
            for (int n = 1; n <= src.Length; n++)
                src[n - 1] = n;
            List<int> ls = new List<int>(src);

            int len = (dimen - 1) * (dimen - 1);
            int[] res = new int[len];
            Random rand = new Random();
            for (int n = 0, m; n < res.Length; n++)
            {
                m = rand.Next(ls.Count);
                res[n] = ls[m];
                ls.RemoveAt(m);
            }

            return res;
        }


        private void fillCheckers()
        {
            for (int i = 0; i < 20; i += 5)
            {
                int sum = 0;
                int index = 0;
                for (int j = 3; j >= 0; j--, index++)
                {
                    sum += int.Parse((container.Children[j + i] as Button).Content.ToString()) * (int)Math.Pow(2, index);
                   (container.Children[i + 4] as Button).Content = sum.ToString();
                }
                /*if (sum == 0)
                {
                    fillRandomly();
                    fillCheckers();
                    fillZeros();
                    checkTable();
                }*/
            }
            
            for (int i=20; i<24; i++)
            {
                int sum=0;
                int index=0;
                for (int j=i-5; j>=i-20;j-=5,index++)
                {
                        sum += int.Parse((container.Children[j] as Button).Content.ToString()) * (int)Math.Pow(2, index);
                        (container.Children[i] as Button).Content = sum.ToString();
                }
                /*if (sum == 0)
                {
                    fillRandomly();
                    fillCheckers();
                    fillZeros();
                    checkTable();
                }*/
            }

        }

        

        private void fillZeros()
        {
            Random random = new Random();
            for (int i = 0; i < 19; i++)
            {
                if ((i + 1) % 5 != 0)
                    (container.Children[i] as Button).Content = "0";
            }
        }

        private void checkTable()
        {
            for (int i = 0; i < 20; i += 5)
            {
                int sum = 0;
                int index = 0;
                for (int j = 3; j >= 0; j--, index++)
                    sum += int.Parse((container.Children[j + i] as Button).Content.ToString()) * (int)Math.Pow(2, index);
                if (int.Parse((container.Children[i + 4] as Button).Content.ToString()) == sum)
                {
                    (container.Children[i + 4] as Button).Background = new SolidColorBrush(Color.FromRgb(20,20,20));
                    (container.Children[i + 4 ] as Button).Name = "did";
                }
                   
                else
                { 
                    (container.Children[i + 4] as Button).Background = new SolidColorBrush(Colors.DimGray);
                }
            }
            
            for (int i = 20; i < 24; i++)
            {
                int sum = 0;
                int index = 0;
                for (int j = i - 5; j >= i - 20; j -= 5, index++)
                {
                    sum += int.Parse((container.Children[j] as Button).Content.ToString()) * (int)Math.Pow(2, index);
                    if (int.Parse((container.Children[i] as Button).Content.ToString()) == sum)
                    {
                        (container.Children[i] as Button).Background = new SolidColorBrush(Color.FromRgb(20, 20, 20));
                        (container.Children[i] as Button).Name = "did";
                    }
                    else
                    {
                        (container.Children[i] as Button).Background = new SolidColorBrush(Colors.DimGray);
                    }
                }
            }
        }
        bool col = false, row = false;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            if (btn.Content.Equals("0"))
            {
                btn.Content = "1";
                btn.Foreground = new SolidColorBrush(Colors.Yellow);
                btn.BorderBrush = new SolidColorBrush(Colors.Yellow);
            }
            else
            {
                btn.Content = "0";
                btn.Foreground = new SolidColorBrush(Colors.LightBlue);
                btn.BorderBrush = new SolidColorBrush(Colors.LightBlue);
            }
            checkTable();
            ch();
        }
        int game1 = 0, game2 = 0;
        private void ch()
        {
            game1 = 0;
            game2 = 0;
            //check column
            for (int i=4;i<24;i+=5)
            {
                    if ((container.Children[i] as Button).Name == "did")
                    {
                        game1++;
                    }
                    if (game1 >= 4) col = true;
            }
            //check row
            for(int i=20; i<24;i++)
            {
                    if ((container.Children[i] as Button).Name == "did")
                    {
                        game2++;
                    }
                    if (game2 >= 4) row = true;
            }
            if (row && col) GameOver();
        }

        private void close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            MainPage MainPage = new MainPage();
            MainPage.Show();
            this.Close();
        }

        private void hide_Click(object sender, RoutedEventArgs e)
        {
            foreach (Window wnd in Application.Current.Windows)
            {
                wnd.WindowState = WindowState.Minimized;
            }
        }
    }
}
