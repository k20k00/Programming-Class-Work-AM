using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntCreateFunction
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        static void MyPrintFunction()
        {
            Console.WriteLine("In MyPrintFunction");
        }
        static void BobPrinter()
        {
            Console.WriteLine("bob bob bob bob bob");
        }
        int Plus(int num1, int num2)
        {
            int num3 = num1 + num2;
            return num3;
        }
        int Minus(int num1, int num2)
        {
            int num3 = num1 - num2;
            return num3;
        }
        int Add1(int num1)
        {
            int num2 = num1 + 1;
            return num2;
        }
    }
}
