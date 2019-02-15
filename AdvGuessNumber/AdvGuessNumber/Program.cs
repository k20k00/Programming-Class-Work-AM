using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvGuessNumber
{
    class Program
    {

        static void Main(string[] args)
        {
            bool Yes = true; //if yes then they play again
            while (Yes == true) // same as above
            {
                Input("Please Enter Your Name"); //ask for input outside of the loop so it doesnt ask for name over and over
                int GeneratedNumber = GenerateNumber(); // generate a number
                int UserInput = GetGuess(); // check their guess to give hints too big or too small
                int NumberOfGuesses = 0; //count their guesses starting at 0
                while (!CheckGuess(GeneratedNumber, UserInput)) //give hints and check if generated number and their guess are the same
                {
                    UserInput = GetGuess(); // get their guess over and over
                    NumberOfGuesses = NumberOfGuesses += 1; //count their guess each time they guess
                    Console.WriteLine(NumberOfGuesses); //print the amount of guesses they have done
                    

                }
                string PlayAgain = " "; 
                Console.WriteLine("Would you like to play again? Yes or No"); //play again for requirement
                PlayAgain = Console.ReadLine(); 
                if (PlayAgain == "Yes" || PlayAgain == "yes" || PlayAgain == "YES") //get it to loop back up to repeat everything to replay the same
                {
                    Yes = true;
                }
                else Environment.Exit(0); //if they type anything other than yes then it exits the code because they're dummy heads and don't want to play my game again
            }
        }
        

        static string Input(string prompt)
        {
            Console.WriteLine(prompt); //print the prompt to get input
            string UserInput = Console.ReadLine();
            return UserInput;
        }

        static int IntInput(string prompt) //print the prompt to convert to int and return it, if not right format print exception
        {
            while (true)
            {
                try
                {
                    int UInput = Convert.ToInt32(Input(prompt));
                    return UInput;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Not an integer");
                }
            }
        }

         static int GenerateNumber() //generate a random number with code given by baker
        {
            Random rand = new Random();
            int n = rand.Next(1, 100);
            return n;
        }

        static int GetGuess() //get input and check if it is between 1 and 100 and if it isn't then re ask for number
        {
            string prompt = "Enter a number between 1 and 100";
            int UserGuessedNumber;
            UserGuessedNumber = IntInput(prompt);
            if (UserGuessedNumber >= 1 && UserGuessedNumber <= 100)
            { }
            else
            {
                Console.WriteLine("Not between 1 and 100");
                UserGuessedNumber = IntInput(prompt);
            }
            return UserGuessedNumber;
            
        }

        static void PrintHint(int theSecretNumber, int userGuessedNumber) //give hints if too big or too small
        {
            if (userGuessedNumber < theSecretNumber)
            {
                Console.WriteLine("Your number was too small");
            }
            if (userGuessedNumber > theSecretNumber)
            {
                Console.WriteLine("Your number was too large");
            }
        }

        static bool CheckGuess(int theSecretNumber, int userGuessedNumber) //check if their answer is right or wrong  and if not then print hint
        {
            bool GuessRorW;
            if (theSecretNumber != userGuessedNumber)
            {
                GuessRorW = false;
                PrintHint(theSecretNumber, userGuessedNumber);
            }
            else {
                GuessRorW = true;
            }
            return GuessRorW;
        }
    }
}
