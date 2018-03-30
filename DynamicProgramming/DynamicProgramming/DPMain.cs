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
            int N=0;
            Console.WriteLine("Welcome to Dynamic Programming!!");
            Console.WriteLine("0. Read Me");
            Console.WriteLine("1. Generate Fibonacci Series");
            Console.WriteLine("2. Coin Row Problem");

            string option =Console.ReadLine();
            switch(option)
            {
                case "0":
                    Console.WriteLine("1. Fibonacci Series");
                    Console.WriteLine("2. Coin Row Problem");
                    string Helpoption = Console.ReadLine();
                    switch(Helpoption)
                    {
                        case "1":
                            //read from file rather than hard coding
                            Console.WriteLine("Fibonacci series is a series which is of the sequence 1,1,2,3,5");
                            Console.WriteLine("in which Nth fibonacci number is got by adding N-1 and N-2 ");
                            Console.WriteLine("fibonacci numbers. Here, We use Top-Down Dynamic Programming");
                            Console.WriteLine("approach to solve the problem");
                            break;
                        case "2":
                            //to be implemented.
                            Console.WriteLine("");
                            break;
                    }
                    break;
                case "1":
                    Console.WriteLine("Enter N for which Fibonacci series is to be calculated");
                    try
                    {
                        N = Convert.ToInt32(Console.ReadLine());
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine("Exception in data: " + e.Message);
                        Console.ReadKey();
                        Environment.Exit(1);
                    }
                    Fibonacci fib = new Fibonacci(N);
                    int fibonac = fib.GenerateFib();
                    Console.WriteLine("Fib("+N+")="+fibonac);
                    Console.ReadKey();
                    break;
                case "2":
                    Console.WriteLine("Enter number of coins");
                    try
                    {
                        N = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Exception in data: " + e.Message);
                        Console.ReadKey();
                        Environment.Exit(1);
                    }
                    int[] CoinValues = new int[N];
                    Console.WriteLine("Enter "+N+" values of Adjacent coins");
                    for (int i = 0; i < N; i++)
                    {
                        try
                        {
                            Console.Write((i + 1) + " coin value: ");
                            CoinValues[i] = Convert.ToInt32(Console.ReadLine());
                        }
                        catch(Exception e)
                        {
                            Console.WriteLine("Exception in data: " + e.Message);
                            Console.ReadKey();
                            Environment.Exit(1);
                        }
                    }
                    CoinRow Coins = new CoinRow(N, CoinValues);
                    int MaxSumValue = Coins.CalculateMaxValue();
                    Console.WriteLine("Maximum value of the Coins by not choosing adjacent coins is: "+MaxSumValue);
                    break;
                default: Console.WriteLine("Invalid choice");
                    break;
            }
            Console.ReadKey();

        }
    }
}
