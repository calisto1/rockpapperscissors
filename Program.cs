using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {

            playGame();
            while  (Console.Read() == '1')
            {
                Console.Clear();
                playGame();
                 
            }
        }

        public static string getFirstPlayerChoice()//creating a method to get first player choice
        {
            Console.Write("First Player Choice : ");
            string choice = Console.ReadLine();

            choice  = choice.ToLower();// just making sure that what ever the user gives us we put it to small caps                               //lower case to have computation
            while (choice !="rock" && choice != "paper" && choice != "scissors")
            {
                Console.WriteLine("chose from these : paper, rock and scissors");
                Console.Write("Please Re-enter your Choice : ");
                choice = Console.ReadLine();
            }
            return choice;
        }


        public static string getSecondPlayerChoice()
        {

            Console.Write("Second Player Choice : ");
            string choice = Console.ReadLine();

            choice = choice.ToLower();// just making sure that what ever the user gives us we put it to 
                                      //lower case to have computation
            while (choice != "rock" && choice != "paper" && choice != "scissors")
            {
                Console.WriteLine("chose from these : paper, rock and scissors");
                Console.Write("Please Re-enter your Choice : ");
                choice = Console.ReadLine();
            }
            return choice;

        }

        public static string determineWinner (string firstPlayerChoice, string secondPlayerChoice) {

            if (firstPlayerChoice == secondPlayerChoice)
            {
                return "The game was a tie";
            }
           else if  (firstPlayerChoice == "rock")
            {
                if (secondPlayerChoice == "paper")
                {
                    return "The Second Player has won the Game";
                }
                else
                {
                    return "The First Player has won won The Game";
                }
            }
            else if (firstPlayerChoice == "paper")
            {
                if (secondPlayerChoice == "scissors")
                {
                    return "The Second Player has won the Game";
                }
                else
                {
                    return "The First Player has won The Game";
                }
            }
            else if  (firstPlayerChoice == "scissors")
            {
                if (secondPlayerChoice == "rock")
                {
                    return "The Second Player has won the Game";
                }
                else
                {
                    return "The First Player! You have won The Game";
                }
            }

            else
            {
                Console.WriteLine(firstPlayerChoice,secondPlayerChoice);
                return "Error Occured RePlay The Game";
            }


        }

        public static void  playGame() {
            
            Console.WriteLine("THE GAME HAS STARTED");
            Console.WriteLine("ROCK PAPER SCISSORS GAME");
            Console.WriteLine("");
            
            Console.WriteLine(determineWinner(getFirstPlayerChoice(), getSecondPlayerChoice()));
            Console.WriteLine("GAME OVER");
            
            Console.WriteLine("Press 1 to start new game");
            Console.ReadKey();
           
           
        }



    }
}
