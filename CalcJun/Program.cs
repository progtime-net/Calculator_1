using System;
using CalcJun.Classes;
using CalcJun.Interfaces;

namespace CalcJun
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            while (true)
            { 
            Calculator calculator = new Calculator();

            calculator.InputAndCalculate();
            }
        }
    }
}