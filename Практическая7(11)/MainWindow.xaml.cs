using System;
using System.Windows;

namespace Практическая7_11_
{
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
            int x = Convert.ToInt32(TextX.Text);
            int y = Convert.ToInt32(TextY.Text);
            double S = 0;
            for(int i = 1; i<=N; i++)
                for(int j = 1; j<=K; j++)
                    S += (i * Math.Pow(x, 2 * i) + j * Math.Pow(y, 2 * j)) / Math.Pow(i, 2) * Math.Pow(j, 2);
            this.Title = "Ответ: " + S.ToString();
        }
    }
}
