using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ex0204
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Write("請輸入你的名字:");
            string name = ReadLine();
            WriteLine($"Good Day! {name}");
        }
    }
}
