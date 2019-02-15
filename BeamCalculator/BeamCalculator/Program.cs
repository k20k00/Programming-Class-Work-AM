using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeamCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            long weight = 0;
            long length = 0;
            double size;
            double Beam = 0;

            Console.WriteLine("Enter a weight the beam will hold at the center point:");
            weight = long.Parse(Console.ReadLine());
            Console.WriteLine("Enter the length of the beam:");
            length = long.Parse(Console.ReadLine());
            Console.WriteLine("Enter size of the beam you want to test for:");
            size = Convert.ToDouble(Console.ReadLine());

            Beam = weight * Math.Pow(length,3)/(48 * 29000000 * (Math.Pow(size,4)/12));

            Console.WriteLine("The beam needs to be this big: " + Beam);
            Console.ReadLine();
        }
    }
}
