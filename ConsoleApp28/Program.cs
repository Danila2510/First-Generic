using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    internal class Program
    {
        static void Swap<T>(ref T first, ref T second)
        {
            T buf = first;
            first = second;
            second = buf;
        }
        static void Main(string[] args)
        {
            int first = 15, second = 20;
            Swap(ref first, ref second);
            Console.WriteLine(first);
            Console.WriteLine(second);
        }
    }
}