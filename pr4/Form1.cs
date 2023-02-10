using System;
using System.IO;
using System.Windows.Forms;

namespace пз4
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();

        private void reshit_Click(object sender, EventArgs e)
        {
            double z = 1;
            double x = double.Parse(tbx.Text);
            double kolvo = double.Parse(tbkolvo.Text);
            for (int i = 2; i - 1 < kolvo; i++)
            {
                if (i % 2 == 0)
                    z -= (Math.Sin(Math.Pow(x, i)) / i);
                else
                    z += (Math.Cos(Math.Pow(x, i)) / i);
            }
            textBox1.Text = "Z = " + z.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog
            {
                FullOpen = true,
                ShowHelp = true,
                Color = reshit.BackColor
            };
            dlg.Color = button1.BackColor;
            dlg.Color = button2.BackColor;
            dlg.Color = button3.BackColor;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                reshit.BackColor = dlg.Color;
                button1.BackColor = dlg.Color;
                button2.BackColor = dlg.Color;
                button3.BackColor = dlg.Color;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FontDialog dlg = new FontDialog
            {
                ShowColor = true,
                ShowHelp = true,
                Font = reshit.Font
            };
            dlg.Font = button1.Font;
            dlg.Font = button2.Font;
            dlg.Font = button3.Font;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                reshit.Font = dlg.Font;
                button1.Font = dlg.Font;
                button2.Font = dlg.Font;
                button3.Font = dlg.Font;
                reshit.ForeColor = dlg.Color;
                button1.ForeColor = dlg.Color;
                button2.ForeColor = dlg.Color;
                button3.ForeColor = dlg.Color;
            }
        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.DefaultExt = "*.tsx";
            dlg.Filter = "Test files|*.txt";
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
                dlg.FileName.Length > 0)
            {
                using (StreamWriter sw = new StreamWriter(dlg.FileName, true))
                {
                    sw.WriteLine(textBox1.Text);
                    sw.Close();
                }
            }
        }
    }
}
