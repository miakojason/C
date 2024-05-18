using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ex0306
{
    enum City :short //各城市郵遞區號
    {
        Taipei=100,
        Sinjhu=300,
        Taijhong=400,
        Taninan=700,
        Kaohsiung=800
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            City zone1, zone2;
            short pt1, pt2;
            zone1 = City.Kaohsiung;
            zone2 = City.Taninan;
            pt1 = (short)City.Sinjhu;
            pt2 = (short)City.Taijhong;
            WriteLine($"城市:{zone1},{zone2}");
            WriteLine($"新竹、台中的郵遞區號:{pt1},{pt2}");

        }
    }
}
