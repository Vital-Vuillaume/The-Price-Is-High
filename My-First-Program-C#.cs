using System;

namespace MyCompiler {
    class Program {
        public static void Main(string[] args) {
            int chips = 5;
            while (chips != 0)
            {
                Console.WriteLine("There are " + chips + " chips left.");  
                chips--;               
            }
            Console.WriteLine("There are no more chips left."); 
        }
    }
}
