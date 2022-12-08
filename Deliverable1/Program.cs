using System;
using System.Runtime.CompilerServices;

class program {
    static void Main(string[] args)
    {
        string input;
        do{
            
            Console.WriteLine("How many people are we making PB&J sandwiches for?");

                    double num1 = int.Parse(Console.ReadLine());
                    double bread = 2 * num1;
                    double pb = 2 * num1;
                    double jl = 4 * num1;
                    double loaf = Math.Ceiling(bread / 28);
                    double jar = Math.Ceiling(pb / 32);
                    double jly = Math.Ceiling(jl / 48);

            Console.WriteLine("We need " + bread + " slice of bread, " + pb + " tbps of peanut butter, and " + jl + " tsp of jelly");
            Console.WriteLine(" That is " + loaf + " loaves of bread, " + jar + " jars of peanut butter, and " + jly + " jars of jelly.");

            Console.WriteLine("Do you need more sandwiches?");
                    input=(Console.ReadLine().ToLower());
        } while (input == "y" || input == "yes"); 
              
        
           Console.WriteLine("Goodbye");

    }
}