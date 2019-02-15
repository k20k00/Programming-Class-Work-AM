using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // write your code here
                int HourTime = 0;
                int MinTime = 0;
                int SecTime = 0;
            string Noon ="";
                //to ask for input
                //get the hour in 12 hour format
               Console.WriteLine("Enter a hour for 12 hour time format: ");
                try
                {
                    HourTime = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException e)
                {
                   Console.WriteLine("Bad Hour Input", e);
                    Environment.Exit(0); //exit code
                }
                if (HourTime < 0 || HourTime > 12)
                {
                    Console.WriteLine("Bad Hour Input");
                }

                //get minute in 12 hour format
                Console.WriteLine("Enter a minute for 12 hour time format: ");
                try
                {
                    MinTime = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                   Console.WriteLine("Bad Minute Input", e);
                    Environment.Exit(0); //exit code
                }
                if (MinTime < 0 || MinTime > 59)
                {
                   Console.WriteLine("Bad Minute Input");
                }


                //get second in 12 hour format
               Console.WriteLine("Enter a second for 12 hour time format: ");
                try
                {
                    SecTime = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                   Console.WriteLine("Bad Second input", e);
                    Environment.Exit(0); //exit code
                }
                if (SecTime < 0 || SecTime > 59)
                {
                   Console.WriteLine("Bad Second Input");
                }
                //AM or PM for transition into 24 hour format (if AM use their number if it's valid, if PM add 12 to their number or set to 0 if it's 12 PM)
               Console.WriteLine("Enter whether your time is AM or PM: ");
                try
                {
                    Noon = Console.ReadLine();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Bad Input", e);
                    Environment.Exit(0); //exit code
                }
            if (Noon == ("AM") || Noon == ("am"))
            {

                if (HourTime == 12)
                {
                    HourTime = 0;
                }
            }
            else if (Noon == (("PM")))
            {
                if (HourTime == 12)
                {
                    HourTime = 12;
                }
                else
                {
                    HourTime = HourTime + 12;
                    MinTime = MinTime + 0;
                    SecTime = SecTime + 0;
                }
            }
            else  {
                Console.WriteLine("Bad AM/PM Input");
            }


            //System.out.print(HourTime + ":"); System.out.print(MinTime + ":"); System.out.print(SecTime + " "); System.out.print(Noon);

            //Translate to military time

            //if AM do nothing to the number they enter just set the variables as themselves
            //if (Noon.equals(("AM"))) {
            // } else {
            //   HourTime = HourTime;
            // MinTime = MinTime;
            //SecTime = SecTime;
            //}}
            //if it's 12 PM then set the hour to 0 because 12PM == 00:00:00 in military but any other PM number just add 12


            //print out final time conversion for the user to see
            Console.WriteLine(HourTime + ":" + MinTime + ":" + SecTime + Noon);

        }
    }
}

