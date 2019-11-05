using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input number: ");
            int a = Convert.ToInt32(Console.ReadLine());
           

            int b, c;
            b = a / 3600;
            c = a / 60 % 60;
            a = a % 60;
            Console.WriteLine($"{b}hours");
            Console.WriteLine($"{c}minutes");
            Console.WriteLine($"{a}seconds");

            Console.ReadLine();

        }
    }
}
