using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ex0307
{
    struct Compter
    {//價格price, 序號serial,製造日期madeDate
        public int price;
        public string serial;
        public DateTime madeDate;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Compter personPC;
            personPC.price = 23_750;
            personPC.serial = "ZCT-20240518A";
            personPC.madeDate = DateTime.Today;
            WriteLine($"電腦價格{personPC.price:c0}"+
                $"\n製造日期{personPC.madeDate:D}"+
                $"\n序號{personPC.serial}");
        }
    }
}
