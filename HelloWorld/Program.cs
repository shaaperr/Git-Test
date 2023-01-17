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
            Console.ReadKey();
            Console.WriteLine(rand.Next(101));
            Console.WriteLine();
            //Program p = new Program();
            //p.setSteve(4);
            //Console.WriteLine("Steve is: " + p.getSteve());
            //Console.ReadKey();
        }
    }
}
