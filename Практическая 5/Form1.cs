using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практическая_5
{
    public partial class Form1 : Form
    {
        private DataStorage data;

        public Form1()
        {
            InitializeComponent();
        }
        
        interface DataInterface
        {
            List<RawDataItem> GetRawData();
            List<SummaryDataItem> GetSummaryData();
        }
        class SummaryDataItem
        {
            public String GroupName { get; set; }
            public float GroupSum { get; set; }
        }
        class Utils
        {
            private static Dictionary<float, String> dict;
            static Utils()
            {
                if (dict == null)
                {
                    dict = new Dictionary<float, string>(4);
                    dict.Add(0, "Товар");
                    dict.Add(1, "Товарная группа");
                    dict.Add(2, "Цена");
                    dict.Add(3, "Склад");
                }
            }
            public static String GetGroupByNumber(float number)
            {
                if (dict.ContainsKey(number))
                    return dict[number];
                else
                    return "???";
            }
        }
        class RawDataItem
        {
            public String Name { get; set; }
            public String Group { get; set; }
            public float Price { get; set; }
            public String Place { get; set; }
        }
        class DataStorage : DataInterface
        {
            public bool IsReady
            {
                get
                {
                    if (rawdata == null) return false;
                    else return true;
                }
            }
            private List<RawDataItem> rawdata;
            private List<SummaryDataItem> sumdata;
            private char devider = '%';
            private DataStorage() { }
            private bool InitData(String datapath)
            {
                rawdata = new List<RawDataItem>();
                try
                {
                    StreamReader sr = new StreamReader(datapath, Encoding.UTF8);
                    String line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] items = line.Split(devider);
                        var item = new RawDataItem()
                        {
                            Name = items[0].Trim(),
                            Group = items[1].Trim(),
                            Price = Convert.ToSingle(items[2].Trim()),
                            Place = items[3].Trim()
                        };
                        rawdata.Add(item);
                    }
                    sr.Close();
                    BuildSummary();
                }
                catch (IOException ex)
                {
                    return false;
                }
                return true;
            }
            private void BuildSummary()
            {
                Dictionary<float, float> tmp = new Dictionary<float, float>();
                sumdata = new List<SummaryDataItem>();
                foreach (var item in tmp)
                {
                    sumdata.Add(new SummaryDataItem()
                    {
                        GroupName = Utils.GetGroupByNumber(item.Key),
                        GroupSum = item.Value
                    });
                }
            }
            public static DataStorage DataCreator(String path)
            {
                DataStorage d = new DataStorage();
                if (d.InitData(path))
                    return d;
                else
                    return null;
            }
            public List<RawDataItem> GetRawData()
            {
                if (this.IsReady)
                    return rawdata;
                else
                    return null;
            }
            public List<SummaryDataItem> GetSummaryData()
            {
                if (this.IsReady)
                    return sumdata;
                else
                    return null;
            }
        }
        private void ShowData(String datapath)
        {
            try
            {
                data = DataStorage.DataCreator(datapath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Что-то сломалось");
            }
            dgRaw.DataSource = data.GetRawData();
            dgRaw.ReadOnly = true;
            dgSummary.DataSource = data.GetSummaryData();
            dgSummary.ReadOnly = true;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Application.StartupPath;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ShowData(openFileDialog1.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            float a = Convert.ToSingle(dgRaw.Rows[0].Cells[2].Value);
            float b = Convert.ToSingle(dgRaw.Rows[1].Cells[2].Value);
            float c = Convert.ToSingle(dgRaw.Rows[4].Cells[2].Value);
            textBox1.Text = (a+b+c).ToString();

            float a1 = Convert.ToSingle(dgRaw.Rows[2].Cells[2].Value);
            float b1 = Convert.ToSingle(dgRaw.Rows[3].Cells[2].Value);
            textBox2.Text = (a1 + b1).ToString();

            float sem = Convert.ToSingle(dgRaw.Rows[1].Cells[2].Value);
            float sem2 = Convert.ToSingle(dgRaw.Rows[4].Cells[2].Value);
            textBox4.Text = ((sem+sem2)/2).ToString();

            float ni = Convert.ToSingle(dgRaw.Rows[2].Cells[2].Value);
            float ni2 = Convert.ToSingle(dgRaw.Rows[3].Cells[2].Value);
            textBox3.Text = ((ni + ni2)/2).ToString();

            textBox5.Text = dgRaw.Rows[0].Cells[2].Value.ToString();
        }
    }
    
    
}
