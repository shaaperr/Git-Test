/* Shakira Perry 
 * 01/17/2023
 * Classwork 1
 */

using System;

namespace Class_work_1
{

    class Program
    {
      /*  private int steve;
        public void setSteve(int s)
        {
            steve = s;
        }

        public int getSteve()
        {
            return steve;
        }*/
        static void Main(string[] args)
        {
            
            var rand = new Random();
            Console.WriteLine("I am thinking of a number between 0 and 100.");
            //Console.ReadKey();
            //Console.WriteLine(rand.Next(101));
            int randN = rand.Next(50, 101);
            //Console.WriteLine(randN);
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


            // Console.WriteLine();
            //Console.Write("{0,8:N0}", rand.Next(50, 101));
            //Program p = new Program();
            //p.setSteve(4);
            //Console.WriteLine("Steve is: " + p.getSteve());
            //Console.ReadKey();
            // Console.WriteLine("Range X?");
            // int userInX = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Limit Y?");
            //int userInY = Convert.ToInt32(Console.ReadLine());

        }
    }
}
