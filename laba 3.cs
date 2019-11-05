using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Input four-digit number: ");

            int a = Convert.ToInt32(Console.ReadLine());
            
            int n, m, b, c;
            n = a % 10;//4
            b = a % 100 / 10;//3
            m = a % 1000 / 100;//2
            c = a / 1000;//1
            if (n == c&& b == m)
            {
                Console.WriteLine("True");
            } else
            {
                Console.WriteLine("False");
            }

            Console.ReadLine();
        }
    }
}
