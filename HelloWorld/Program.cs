/* Shakira Perry 
 * 01/17/2023
 * Classwork 1
 */

using System;

namespace Class_work_1
{

    class Program
    {
        static void Main(string[] args)
        {
            
            var rand = new Random();
            Console.WriteLine("I am thinking of a number between 0 and 100.");
           
            int randN = rand.Next(101);
            
            Console.WriteLine("What number am I thinking of? ");
            int userIn = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            while (userIn != randN){
                
                    if (userIn > randN)
                    {
                        Console.WriteLine("You are above the number I'm thinking of!");
                        Console.WriteLine("What number am I thinking of? ");
                        userIn = Convert.ToInt32(Console.ReadLine());
                    }
                    else if (userIn < randN)
                    {
                        Console.WriteLine("You are below the number I'm thinking of!");
                        Console.WriteLine("What number am I thinking of? ");
                        userIn = Convert.ToInt32(Console.ReadLine());
                    }
                    
                count++;
                }
            Console.WriteLine("\n Correct guess! It took you " + count + " tries.");

            
            
/*
            Console.WriteLine("Range X?");
            int userInX = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Limit Y?");
            int userInY = Convert.ToInt32(Console.ReadLine());

            int randN = rand.Next(50, 101); */

        }
    }
}
