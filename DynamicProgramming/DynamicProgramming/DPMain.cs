﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DynamicProgramming.Problems;

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
            Console.WriteLine("3. Change Making Problem");
            Console.WriteLine("4. Coin Collecting Problem");
            Console.WriteLine("5. Rod Cutting Problem");

  
            string option =Console.ReadLine();
            switch(option)
            {
                case "0":
                    Console.WriteLine("1. Fibonacci Series");
                    Console.WriteLine("2. Coin Row Problem");
                    Console.WriteLine("3. Change Making Problem");
                    Console.WriteLine("4. Coin Collecting Problem");
                    Console.WriteLine("5. Rod Cutting Problem");
                    string HelpOption = Console.ReadLine();
                    switch(HelpOption)
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
                        case "3":
                            //to be implemented.
                            Console.WriteLine("");
                            break;
                        case "4":
                            //to be implemented.
                            Console.WriteLine("");
                            break;

                        default:
                            Console.WriteLine("Invalid choice");
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
                case "3":
                    Console.WriteLine("Enter Number of coins");
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
                    int []CoinValue = new int[N];
                    Console.WriteLine("Enter " + N + " values coin values");
                    for (int i = 0; i < N; i++)
                    {
                        try
                        {
                            Console.Write((i + 1) + " coin value: ");
                            CoinValue[i] = Convert.ToInt32(Console.ReadLine());
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Exception in data: " + e.Message);
                            Console.ReadKey();
                            Environment.Exit(1);
                        }
                    }
                    Console.WriteLine("Enter denomination to be found");
                    int Denomination = 0;
                    try
                    {
                        Denomination = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Exception in data: " + e.Message);
                        Console.ReadKey();
                        Environment.Exit(1);
                    }
                    ChangeMaking Chg = new ChangeMaking(N,CoinValue,Denomination);
                    int []ResultDenomination=Chg.CalculateDenominations();
                    Console.WriteLine("Total number of coins required: " + ResultDenomination.Count());
                    Console.WriteLine("The values of coins are: ");
                    foreach(int i in ResultDenomination)
                    {
                        Console.Write(i + " ");
                    }
                    break;
                case "4":
                    Console.WriteLine("Enter number of rows");
                    int rows = 0, cols = 0;
                    try
                    {
                        rows = Convert.ToInt32(Console.ReadLine());
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine("Exception in data" + e.Message);
                        Console.ReadKey();
                        Environment.Exit(1);
                    }
                    Console.WriteLine("Enter number of columns");
                    try
                    {    
                        cols = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Exception in data" + e.Message);
                        Console.ReadKey();
                        Environment.Exit(1);
                    }
                    int[,] matrix = new int[rows,cols];
                    Console.WriteLine("Enter 1 for rows with coins and 0 otherwise");
                    for(int i=0;i<rows;i++)
                    {
                        Console.WriteLine("Row " + (i + 1));
                        for(int j=0;j<cols;j++)
                        {
                            try
                            {
                                matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Exception in data" + e.Message);
                                Console.ReadKey();
                                Environment.Exit(1);
                            }
                        }
                    }
                    CoinCollecting CoinCollector = new CoinCollecting(matrix, rows, cols);
                    int coins = CoinCollector.MaximumCoinsCollected();
                    Console.WriteLine("Maximum coins that can be collected by a robot navigating left and down is: " + coins);
                    break;
                case "5":
                    Console.WriteLine("Enter Length of Rod to be cut");
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
                    int[] RodPrice = new int[N];
                    Console.WriteLine("Enter price of Pieces");
                    for (int i = 0; i < N; i++)
                    {
                        try
                        {
                            Console.Write((i + 1) + " piece's price value: ");
                            RodPrice[i] = Convert.ToInt32(Console.ReadLine());
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Exception in data: " + e.Message);
                            Console.ReadKey();
                            Environment.Exit(1);
                        }
                    }
                    RodCutting RodCut = new RodCutting(N, RodPrice);
                    Tuple<int[],int> RodPieces = RodCut.CalculateOptimalCuts();
                    Console.WriteLine("Total number of cuts required: " + RodPieces.Item1.Count());
                    Console.WriteLine("The length of pieces are: ");
                    foreach (int i in RodPieces.Item1)
                    {
                        Console.Write(i + " ");
                    }
                    Console.WriteLine("\nMaximum value obtained by cutting rods is:"+ RodPieces.Item2);
                    break;
                default: Console.WriteLine("Invalid choice");
                    break;
            }
            Console.ReadKey();

        }
    }
}
