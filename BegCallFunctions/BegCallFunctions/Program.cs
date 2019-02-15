using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BegCallFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            /* copy the below into a new project The comments below should be put in the main function.*/
            //call MyFunction1
            MyFunction1();
            //call Function2
            Function2();
            //call Function3
            Function3();
            //call ExampleFunction4
            ExampleFunction4();
            //call TestFunction5
            TestFunction5();
            //call Function2 again
            Function2();
            //call Function2 again
            Function2();
            //call ExampleFunction4 again
            ExampleFunction4();
            //call Function2 again
            Function2();
            //call TestFunction5 again
            TestFunction5();

            /* copy this to your project but make sure that it is outside the main function but still within the class*/
        }
        static void MyFunction1()
        {
            Console.WriteLine("Printing stuff");
            Console.WriteLine("Here is more stuff to print");
        }
        static void Function2()
        {
            Console.WriteLine("Hello");
            Console.WriteLine("World");
        }
        static void Function3()
        {
            Console.WriteLine("This is fun");
            Console.WriteLine("No it is not");
        }
        static void ExampleFunction4()
        {
            Console.WriteLine("Why did the Scarecrow get a promotion?");
            Console.WriteLine("because he was out standing in his field!");
        }
        static void TestFunction5()
        {
            Console.WriteLine("Why do chicken coops only have two doors?");
            Console.WriteLine("Because if they had four, they would be chicken sedans!");



        }
    }
}
