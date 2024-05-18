// See https://aka.ms/new-console-template for more information
using static System.Console;
//題目找出count,只找基數到20, sum累加 60停。
int count, sum = 0;
for (count = 0; count <= 20; count++)
{
    if (count % 2 == 0)
    {
        continue;
    }
    sum += count;
    if (sum >= 60)
    {
        break;
    }
        WriteLine($"Count ={count},Sum={sum}");
}
ReadKey();
