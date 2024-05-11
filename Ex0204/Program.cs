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
            Write("菜鳥工程師請介紹你自己:");
            string info = ReadLine();
            WriteLine($"Good Day! {info}");
        }
    }
}
