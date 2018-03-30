using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgramming
{
    class DynamicPro
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Dynamic Programming!!");
            Console.WriteLine("1. Generate Fibonacci Series");
            string option=Console.ReadLine();
            switch(option)
            {
                case "1":
                    Console.WriteLine("Enter N for which Fibonacci series is to be calculated");
                    int N = Convert.ToInt32(Console.ReadLine());
                    Fibonacci fib = new Fibonacci(N);
                    int fibonac = fib.GenerateFib();
                    Console.WriteLine("Fib("+N+")="+fibonac);
                    Console.ReadKey();
                    break;
                default: Console.WriteLine("Invalid choice");
                    break;
            }
            Console.ReadKey();

        }
    }
}
