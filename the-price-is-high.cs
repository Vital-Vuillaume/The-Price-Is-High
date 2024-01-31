using System;

namespace MyCompiler {
    class Program {
        public static void Main(string[] args) {

            string again;

            do {
                // Random nb

                Random rng = new Random();
                int nbRng = rng.Next(0, 101);

                // Input player

                int inputResult;
                bool isValidInput = false;
                
                // Sentence

                string sentence = "Enter a number between 1 and 100: ";
                Console.WriteLine(sentence);
                
                do
                {
                    string input = Console.ReadLine();
                    isValidInput = int.TryParse(input, out inputResult);
                    
                    if (!isValidInput)
                    {
                        Console.WriteLine(sentence);
                    }
                    else if (inputResult > nbRng)
                    {
                        Console.WriteLine("The number " + inputResult + " is too big.");
                    }
                    else if (inputResult < nbRng)
                    {
                        Console.WriteLine("The number " + inputResult + " is too small.");
                    }
                } while (!isValidInput || inputResult != nbRng);

                // Result

                Console.WriteLine("\n////////////// Well done was the number " + nbRng + ".//////////////");

                // Sentences to start over.

                Console.WriteLine("\nDo you want to do it all over again? [y or n]");
                again = Console.ReadLine();
            }while(again == "y");
        }
    }
}
