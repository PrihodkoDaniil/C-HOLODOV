using System;
using System.Collections.Generic;

namespace pr5
{
    class Utils
    {
        private static Dictionary<int, String> dict;
        static Utils()
        {
            if (dict == null)
            {
                dict = new Dictionary<int, string>(5)
                {
                    { 0, "Продукты" },
                    { 1, "Бытовая химия" },
                    { 2, "Одежда" },
                    { 3, "Фрукты" },
                    { 4, "Полиграфия" }
                };
            }
        }

        public static String GetGroupByNumber(int number)
        {
            if (dict.ContainsKey(number))
                return dict[number];
            else
                return "???";
        }
    }
}
