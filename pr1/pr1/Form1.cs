using System;
using System.Windows.Forms;

namespace pr1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Text = string.Format("Координаты: {0}, {1}", e.X, e.Y);
            textBox6.Text = (e.X).ToString();
            textBox5.Text = (e.Y).ToString();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            string input2 = textBox2.Text;
            string input3 = textBox3.Text;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            double q = double.Parse(textBox1.Text);
            textBox4.Text += Environment.NewLine + "q = " + q.ToString();
            double ee = double.Parse(textBox2.Text);
            textBox4.Text += Environment.NewLine + "e = " + ee.ToString();
            double y = double.Parse(textBox3.Text);
            textBox4.Text += Environment.NewLine + "y = " + y.ToString();
            double s = double.Parse(textBox6.Text);
            textBox4.Text += Environment.NewLine + "s = " + s.ToString();
            double g = double.Parse(textBox5.Text);
            textBox4.Text += Environment.NewLine + "g = " + g.ToString();
            double R = q + Math.Abs(Math.Pow(Math.Sin(ee), 2) + Math.Cos(y)) * Math.Cos(s + g);
            textBox4.Text += Environment.NewLine + "Результат R = " + R.ToString();
        }
    }
}
