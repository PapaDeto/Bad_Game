using System;
using System.Security.Cryptography;
class Game
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World");

        Console.WriteLine("Welcome, Type S to start.\n");
        
        string start = Console.ReadLine();
        if (start == "S"){
            
            Console.WriteLine("\nAs the first rays of sunlight break through the trees, " +
                "you slowly stir awake, the soft rustling of flowers around you filling " +
                "the quiet morning air. A sea of vibrant blooms stretches out beneath you, " +
                "their colors dancing in the warm light. The scent of earth and wildflowers " +
                "mingles, soothing your senses. But the peaceful meadow is not without its " +
                "boundaries—the towering trees of a dense forest rise up like silent sentinels, " +
                "their shadows looming just beyond the field, hiding whatever lies beyond.");
        }
    }
}

