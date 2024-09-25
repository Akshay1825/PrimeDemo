using PrimeDemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Prime prime = new Prime();

            Console.WriteLine("Enter a number :");
            int number = int.Parse(Console.ReadLine());

            string answer = prime.IsPrime(number)
                            ? $"{number} is a prime number."
                            : $"{number} is not a prime number.";

            Console.WriteLine(answer);
        }
    }
}
