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

namespace Практическая7_11_
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

        private void Calc_click(object sender, RoutedEventArgs e)
        {
            int N = Convert.ToInt32(ComboN.Text);
            int K = Convert.ToInt32(ComboK.Text);
            int a = Convert.ToInt32(TextA.Text);
            int x = Convert.ToInt32(TextX.Text);
            int f = Convert.ToInt32(TextF.Text);
            int y = Convert.ToInt32(TextY.Text);
            double S = 0;
            for(int i =1;i<=N;i++)
                for(int j =1;j<=K;j++)
                    S+=(Math.Pow(a,(i-1))*Math.Pow(x,i)+Math.Pow(f,j)*Math.Pow(y,j))/((i+1)*j);
            this.Title = "Ответ: " + S.ToString();
        }
    }
}
