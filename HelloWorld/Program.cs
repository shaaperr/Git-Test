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

            Console.WriteLine("Range X (minimum)?");
            int userInX = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Limit Y? (maximum)");
            int userInY = Convert.ToInt32(Console.ReadLine());

            int randN = rand.Next(userInX, userInY);

            Console.WriteLine("I am thinking of a number between X and Y.");


            Console.WriteLine("What number am I thinking of? ");
            int userIn = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            while (userIn != randN)
            {

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

        }
    }
}
