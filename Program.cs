using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingNumber
{
    class Program
    {



        static void Main(string[] args)
        {
            bool displayMenu = true;
            while (displayMenu)
            {
                displayMenu = MainMenu();

            }
        }
        static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Welcome to guessing game:");
            Console.WriteLine("=========================");
            Console.WriteLine("Option 1 = Press 1 to play human guessing game");
            Console.WriteLine("Option 2 = Press 2 to play computer guessing game");
            Console.WriteLine("Option 3 = Press 0 to exit the menu");
            string result = Console.ReadLine();

            if (result == "1")
            {
                HumanPlay();
                return true;
            }

            else if (result == "2")
            {
                ComputerPlay();
                return true;
            }
            else if (result == "0")
            {
                return false;

            }
            else
            {
                return true;
            }


        }

        static void HumanPlay()
        {
            Console.Clear();
            Random ran = new Random();
            int winNum = ran.Next(1, 100);
            int count = 1;
            bool win = false;
            Console.WriteLine("Welcome to Human Guessing Game!");
            Console.WriteLine("=============================\n");

            Console.Write("Please Guess a number between 1 to 100:");


            do
            {
                int input = int.Parse(Console.ReadLine());

                if (input > 100 || input < 1)
                {
                    Console.WriteLine("The number was not between 1 to 100. Try again.");
                    Console.Write("Please Guess a number between 1 to 100:");
                }



                else if (input > winNum)
                {
                    Console.Write("\n");
                    Console.Write("The number you enter is high, try again:");
                    count++;
                }



                else if (input < winNum)
                {
                    Console.Write("\n");
                    Console.Write("The number you enter is low, try again:");
                    count++;
                }

                else if (input == winNum)
                {
                    Console.WriteLine("Congratulations! YOU WIN.... you guessed the right number.\n");
                    Console.WriteLine($"It took you {count} tries.");
                    win = true;
                }

            } while (win == false);

            Console.Write("\n");
            Console.WriteLine("Thank you for playing the game.\n");
            Console.ReadLine();

        }

        static void ComputerPlay()
        {

            Console.Clear();
            Random random = new Random();
            int randomNumber = random.Next(1, 100);
            int guess;
            int numberOfGuesses = 0;
            bool win = false;
            Console.WriteLine("I am thinking of a number between 1 and 100! what it is it?");

            do
            {
                guess = int.Parse(Console.ReadLine());
                numberOfGuesses++;

                if (guess > 100 || guess < 1)
                {
                    Console.WriteLine("The number was not between 1 to 100. Try again.");
                    Console.Write("Please Guess a number between 1 to 100:");
                }
                else if (guess == randomNumber)
                {
                    Console.WriteLine("Congratulations! YOU WIN.... you guessed the right number.\n");
                    Console.WriteLine($"It took you {numberOfGuesses} guess.");
                    win = true;
                }

                else if (guess > randomNumber)
                {
                    Console.Write("\n");
                    Console.Write("The number you enter is high, try again:");
                }

                else if (guess < randomNumber)
                {
                    Console.Write("\n");
                    Console.Write("The number you enter is low, try again:");
                }

            } while (win == false);


            Console.Write("\n");
            Console.WriteLine("Thank you for playing the game.\n");
            Console.ReadLine();

        }


    }
}