using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int lives = 7;

            var words = new[] { "WORD", "DOMINIC", "PHILIPPINES", "HELLO", "WORLD", 
                "OKAY", "CODING", "NOVUS", "SOFTWARE", "DEVELOPER", "GRADUATE" };

            var ranWord = words[new Random().Next(0, 10)];

            char[] ranWordArray = ranWord.ToCharArray();

            var guesses = new List<char>();

            char[] guessed = new char[ranWord.Length];
            
            //Console.WriteLine(guessed);

            Console.WriteLine($"{ranWord}");

            //char guess;
            
            while (lives > 0)
            {
                

                Console.WriteLine();
                Console.WriteLine(guessed);

                Console.WriteLine("Guess a letter in the word: ");

                var guess = Console.ReadLine()[0];

                int counter = -1;
                foreach (char letter in guessed)
                {
                    if (ranWordArray[counter+1] == guess)
                    {
                        counter++;
                        guessed[counter] = guess;
                    }
                    else
                    {
                        counter++;
                        guessed[counter] = '-';
                    }
                }

                if (ranWord.Contains(guess) | guesses.Contains(guess))
                {
                    if (guesses.Contains(guess))
                    {
                        Console.WriteLine($"You already guessed {guess}");
                    }
                    else
                    {
                        guesses.Add(guess);
                    }

                }
                else
                {
                    lives--;
                    Console.WriteLine($"The word does not have {guess}... you have {lives} lives left!");
                    guesses.Add(guess);   
                }
                
            }

            Console.WriteLine("!!! GAME OVER !!!");
            Console.ReadLine();
        }
    }
}
