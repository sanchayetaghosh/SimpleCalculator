using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Calculator !");
            
            Console.WriteLine("Please provide the operator to procceed :\n1. Addition\n2. Subtraction\n3. Division\n4. Multiplication");

            string operatorAction = Console.ReadLine();


            
            switch (operatorAction)
            {
                case "Addition":
                    Print(Calculator.Addition());
                    break;
                case "Subtraction":
                    Print(Calculator.Subtraction());
                    break;
                case "Division":
                    Print(Calculator.Division());
                    break;
                case "Multiplication":
                    Print(Calculator.Multiplication());
                    break;
                default:
                    Console.WriteLine("Kindly insert a valid input");
                    break;
            }

            
        }

        public static void Print(int result)
        {
            Console.WriteLine("The result is = " + result);
        }
    }
}
