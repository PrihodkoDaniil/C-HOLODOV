using System;
using System.Windows.Forms;

namespace pr2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            for (int n0 = 1; n0 <= 10; n0++)
            {
                comboBox1.Items.Add(n0.ToString());
                comboBox2.Items.Add(n0.ToString());
            }
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox4.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                textBox3.Text = null;
                int n = Convert.ToInt32(comboBox1.Text);
                int r = Convert.ToInt32(comboBox2.Text);
                double Z = 0;
                int k = 3;
                if (radioButton1.Checked)
                {

                    double x = Convert.ToDouble(textBox1.Text);
                    int x0 = 2;
                    for (int i = 2; i < n; i++)
                    {
                        if (i % 2 == 0)
                        {
                            Z += Math.Round(Math.Pow(x, i) / x0, 3);
                        }
                        else
                        {
                            Z -= Math.Round(Math.Pow(x, i) / x0, 3);
                        }
                        k += 1;
                        x0 *= k;
                    }
                    textBox3.Text = Z.ToString();
                }
                else if (radioButton2.Checked)
                {
                    textBox2.Visible = true;
                    double b = Convert.ToDouble(textBox2.Text);
                    double c = Convert.ToDouble(textBox4.Text);
                    for (int i = 1; i <= n; i++)
                    {
                        for (int j = 1; j <= r; j++)
                        {
                            Z += (Math.Pow(i, 2) + b * j) / (Math.Pow(c, i) + Math.Pow(i, 3));
                        }
                    }
                    textBox3.Text = Math.Round(Z, 3).ToString();
                }
            }
            catch
            {
                MessageBox.Show("Прочитай условие задачи!");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox2.Visible = false;
            textBox4.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Visible = true;
            textBox1.Visible = false;
            textBox4.Visible = true;
        }
    }
}
