using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{
    internal class Program
    {
        //1. Write C# program to print multiplication table of a given number. Ask the user for the number.
        //2. Write C# program to print sum of digits enter by user. Keep asking for numbers, until the user provides 0.
        static void Main(string[] args)
        {
            int multiplication, multiplication_length, summition, result=0;
            string Q;
            do
            {
                do
                {
                    Console.WriteLine("Please choose Q1: (multiplication table of a given number), Q2: (sum of digits enter by user), or Exit");
                    Q = Console.ReadLine();
                    Q = Q.ToLower();
                } while (Q != "q1" && Q != "q2" && Q!="exit");

                switch (Q)
                {
                    case "q1":
                        {
                            Console.WriteLine("Please enter the number you want the multiplication table for it: ");
                            multiplication = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Please enter the length of the multiplication table: ");
                            multiplication_length = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("The multiplication table for " + multiplication +" is:");
                            for (int i = 1; i <= multiplication_length; i++)
                            {
                                Console.WriteLine(i + " * " + multiplication + " = " + i * multiplication);
                            }
                            break;
                        }
                    case "q2":
                        {
                            do
                            {
                                Console.WriteLine("Please enter the number you want the summition for (enter '0' to get the result):");
                                summition = Convert.ToInt32(Console.ReadLine());
                                result = result + summition;
                            } while (summition != 0);
                            Console.WriteLine("The summition for the numbers you entered is: " + result);
                            break;
                        }
                    case "exit":
                        {
                            break;
                        }
                }
            } while (Q != "exit");
        }
    }
}
