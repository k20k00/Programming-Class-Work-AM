using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intwhileloopsSavingsCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double YC = 0;
            double SB = 0;
            double input = 0;
            double blu = 0;
            double Return = 0;
            int NOY;
            double Percent;

            Console.WriteLine("enter starting balance in dollars");
            SB = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter yearly contribution");
            YC = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter average return on investment as %");
            Return = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter number of years to calculate");
            input = Convert.ToDouble(Console.ReadLine());

            Return = Return / 100;
            NOY = 0;
            while (NOY <= input) {
                Console.WriteLine(SB); //print first year starting balance
                blu = SB + YC; //each year balance = starting balance + yearly contribution
                Percent = blu * Return; //average return on investment %
                SB = blu + Percent; //starting balance = blu + percent == new year balance
                NOY++; //number of years incremented
            }
            Console.ReadLine();
        }
    }
}