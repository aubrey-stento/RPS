using System;

namespace hwapp
{
    class Program
    {
        static void Main(string[] args)
        {
           string[] choices = { "rock", "paper", "scissors" }; 
            Console.WriteLine("Choose Rock, Paper, or Scissors");
            string userChoice = Console.ReadLine().ToLower();
            Random random = new Random();
            string compChoice = choices[random.Next(0, 3)];
            if (compChoice == "rock")
            {
                if (userChoice == "rock")
                {
                    Console.WriteLine("The computer chose rock");
                    Console.WriteLine("Tie!");
                }
        
           
            
                 else if (userChoice == "paper")
                {
                    Console.WriteLine("The computer chose rock");
                    Console.WriteLine("You won! Paper beats rock");
                }
            
            
            
                else if (userChoice == "Scissors")
                {
                    Console.WriteLine("The computer chose rock");
                    Console.WriteLine("You lost! Rock beats paper");
                }
            }



            else if (compChoice == "paper")
            {
                if (userChoice == "rock")
                {
                    Console.WriteLine("The computer chose paper");
                    Console.WriteLine("You Lost! Paper beats Rock");
                }
            
    
                else if (userChoice == "paper")
                {
                    Console.WriteLine("The computer chose paper");
                    Console.WriteLine("Tie!");
                }
            
            
            
                else if (userChoice == "scissors")
                {
                    Console.WriteLine("The computer chose paper");
                    Console.WriteLine("You Won! Scissors beats Paper");
                }
            }

            else if (compChoice == "scissors")
            {
                if (userChoice == "Rock")
                {
                    Console.WriteLine("The computer chose scissors");
                    Console.WriteLine("You Won! Rock beats Scissors");
                }
            
    
                else if (userChoice == "Paper")
                {
                    Console.WriteLine("The computer chose scissors ");
                    Console.WriteLine("You Lost! Scissors beats Paper");
                }
            
            
            
                else if (userChoice == "Scissors")
                {
                    Console.WriteLine("The computer chose scissors");
                    Console.WriteLine("Tie");
                }
            }
            else{
                System.Console.WriteLine("SOMETHING BROKE?");
            }

            
        }
    }
}
