using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvLoopsPrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //ask for input
            double one = 0;
            double two = 0;
            Console.WriteLine("Enter number");
            string Sone = Console.ReadLine();
            Console.WriteLine("Enter number");
            string Stwo = Console.ReadLine();
            
            try
            {
                one = Convert.ToDouble(Sone);
                two = Convert.ToDouble(Stwo);
                for (double i = one; i <= two; i++)
                {
                    if ( i < 0 )
                    {
                        if ( i <= 1) //doesn't print negative numbers but will go above 0 and print inbetween
                        {
                            i = 0;
                        }
                    }
                    int num = 2;
                    bool Prime = true;
                    while (num < i)
                    {
                        if (i % num == 0) //divides number by 2 to see if it's divisible
                        {
                            Prime = false; //wont print out cause false
                        }
                        num++; //makes num count up until the loop ends
                    }
                    //negative numbers can't be prime so if one is less than 0 it will never be prime
                    
                    if (Prime && i != 1 && i != 0) //1 will show up as prime number for computer so if it's not 1 and it's still prime then print that number which is prime
                    {
                        Console.WriteLine(i); //print the prime number
                    }
             
                }
                for (double i = two; i <= one; i++) 
                {
                    if (i < 0)
                    {
                        if (i <= 1) //check if it's negative
                        {
                            i = 0;
                        }
                    }
                    int num = 2;
                    bool Prime = true;
                    while (num < i)
                    {
                        if (i % num == 0) //check if its divisible by 2, if it can then it's not prime
                        {
                            Prime = false; //not prime
                        }
                        num++; //not prime
                    }
                    
                    if (Prime && i != 1 && i != 0) //not divisible by 2 and doesn't equal 1 then it prints out the number
                    {
                        Console.WriteLine(i);
                    }
                    
                }
            }
            catch (FormatException ex) //letters = error
            {
                Console.WriteLine("Invalid input"); //if they enter letters it gives error
            }
            Console.ReadLine();
         }
       
    }
}
