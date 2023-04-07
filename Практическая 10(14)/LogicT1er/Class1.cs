using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTier1;

namespace LogicT1er
{
    public class Магазин
    {
        private List<ТоварнаяПозиция> _товары = new List<ТоварнаяПозиция>();
        public Магазин()
        {
            List<Products> tmp = AllProducts.TakeAllProducts();
            foreach (var t in tmp)
            {
                _товары.Add(new ТоварнаяПозиция(t));
            }
        }
        public List<ТоварнаяПозиция> Список_товаров
        {
            get { return _товары; }
        }
        public string Наименованиемагазина
        {
            get { return "Our shop"; }
        }
        public float СуммаПрибыли
        {
            get
            {
                return _товары.Sum(p => p.СуммаПрибыли);
            }
        }
        public float СредняяпоХимии
        {
            get
            {
                return _товары.Sum(p => p.СредняяпоХимии);
            }
        }
        public float СредняяпоПродуктам
        {
            get
            {
                return _товары.Sum(p => p.СредняяпоПродуктам);
            }
        }
    }

    public class ТоварнаяПозиция
    {
        private Products _товар;
        public ТоварнаяПозиция(Products p)
        {
            _товар = p;
        }
        public String Товар
        {
            get { return _товар.Product; }
            set { _товар.Product = value; }
        }
        public String Группа_Товара
        {
            get { return _товар.Group; }
            set { _товар.Group = value; }
        }
        public float Цена_Закупки
        {
            get { return _товар.Purchase; }
            set { _товар.Purchase = value; }
        }
        public float Цена_Продажи
        {
            get { return _товар.Sale; }
            set { _товар.Sale = value; }
        }
        public string ПредставлениеТовара
        {
            get
            {
                return _товар.Product + " " + _товар.Group + " "
                    + _товар.Purchase.ToString("C") + " " + _товар.Sale.ToString("C");
            }
        }
        public float СуммаПрибыли
        {
            get 
            {
                float a = 0;
                if(_товар.Sale!=null)
                { 
                    a+= _товар.Sale;
                }
                return a; 
            }
        }
        public float СредняяпоХимии
        {
            get
            {
                float a = 0;
                if (_товар.Group == "Химия")
                {
                    a += _товар.Purchase;
                }
                return a/2;
            }
        }
        public float СредняяпоПродуктам
        {
            get
            {
                float a = 0;
                if (_товар.Group == "Продукты") 
                {
                    a += _товар.Purchase;
                }
                return a/3;
            }
        }
    }
}
