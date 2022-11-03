using System;
using System.IO;

namespace Wordl
{
    public class Wordl
    {
        public static void Main()
        {
            bool win = false;
            string path = "./wordBank.txt";
            string[] wordBank = File.ReadAllLines(path);
            string word = wordBank[new Random().Next(wordBank.Length)];
            char[] lettersCorrect = new char[5];
            char[] lettersContained = new char[5];
            //Console.WriteLine(word);


            while (!win)
            {
                Console.WriteLine("Guess the word:");
                char [] guess = Console.ReadLine().ToCharArray();

                if (!(guess.Length == 5))
                {
                    Console.WriteLine("Please enter a five-letter word.");
                    continue;
                }

                for (int i = 0; i < word.Length; i++)
                {
                    // if (lettersCorrect[i] == word[i])
                    // {
                    //     lettersCorrect[i] = word[i];
                    // }
                    if (guess[i] == word[i])
                    {
                        lettersCorrect[i] = guess[i];
                    }
                    else if (word.Contains(guess[i]))
                    {
                        lettersCorrect[i] = '-';
                        if(!(lettersCorrect.Contains(guess[i])))
                        {
                            lettersContained[i] = guess[i];
                        }
                        else
                        {
                            lettersContained[i] = ' ';
                        }
                        if(!(lettersContained.Contains(guess[i])))
                        {
                            lettersContained[i] = guess[i];
                        }
                        

                    }
                    else 
                    {
                        lettersCorrect[i] = '-';
                    }
                }
                if (!(lettersCorrect.Contains('-'))){
                    win = true;
                }
                if (!win)
                {
                    Console.WriteLine("These letters are correct: {0}\nThe word contains these letters: {1}\n", new string(lettersCorrect), new string(lettersContained));
                }
            }
            
            Console.WriteLine($"Congrats! The word was {word}!");
        }
    }
}