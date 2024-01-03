using System;

namespace MyCompiler {
    class Program {
        public static void Main(string[] args) {
            
            // Random nb
            Random rng = new Random();
            int nbRng = rng.Next(1, 101);

            // Input player
            string input = Console.ReadLine();
            int inputResult = int.Parse(input);

            // Find nb
            while(inputResult != nbRng)
            {
                if(inputResult > nbRng)
                {
                    Console.WriteLine("Le nombre " + inputResult + " est trop grand.");
                }
                else
                {
                    Console.WriteLine("Le nombre " + inputResult + " est trop petit.");
                }
                input = Console.ReadLine();
                inputResult = int.Parse(input);
            }

            // Result
            Console.WriteLine("Bien joue c'etait le nombre " + nbRng);
        }
    }
}
