using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTier1
{
    public class Products
    {
        public string Product { get; set; }
        public string Group { get; set; }
        public float Purchase { get; set; }
        public float Sale { get; set; }

    }
    public class AllProducts
    {
        public static List<Products> TakeAllProducts()
        {
            char devider = '%';
            List<Products> list = new List<Products>();
            StreamReader sr = new StreamReader("Ishod.txt", Encoding.UTF8);
            String line;
            while ((line = sr.ReadLine()) != null)
            {
                string[] items = line.Split(devider);
                var item = new Products()
                {
                    Product = items[0].Trim(),
                    Group = items[1].Trim(),
                    Purchase = Convert.ToSingle(items[2].Trim()),
                    Sale = Convert.ToSingle(items[3].Trim())
                };
                list.Add(item);
            }
            sr.Close();
            return list;
        }
    }
}
