using System;

namespace DataBase
{
    class RawDataItem
    {
        public String Name { get; set; }
        public int Group { get; set; }
        public String Part { get; set; }
        public float Price { get; set; }
        public float Count { get; set; }
        public float Sum
        {
            get { return Count * Price; }
        }
    }
}
