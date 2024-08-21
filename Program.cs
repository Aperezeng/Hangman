using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numGuesses = 10;
            int userTries = 0; 
            string userGuess = "";
//List with multiple words to choose from 
            List<string> theWords = new List<string>()
            {
                "Blackberry", "Blueberry", "Strawberry", "Cherry", "Raspberry", "Elderberry"
            };
// will throw a random index
            Random rnd = new Random();
            int randomIndexer = (rnd.Next(0, int.Abs(theWords.Count)));
//will throw a randon string from the List
            string theChosenOne = theWords[randomIndexer];
//will ask user to enter a guess
            Console.WriteLine("Guess the word. Here we go! Enter a letter");
//user will enter their guess
            string val = "";
            Console.ReadKey(); 
//user's input string will convert to character
            char userInput = Convert.ToChar(val);
//will reiterate through the random word
        for (int i = 0; i < theChosenOne.Length; i++)
            if (userTries > theChosenOne.Length)
            {
                Console.WriteLine("You've ran out of chances!!");
            }
            if(theChosenOne.Contains(userGuess, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"{userGuess} is in the word! Keep it on!");
            }
            if (!theChosenOne.Contains(userGuess, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"{userGuess} is not in the word. Keep on guessing.");
            }
        }
    }
}


  
    


