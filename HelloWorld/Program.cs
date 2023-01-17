/* Shakira Perry 
 * 01/17/2023
 * Classwork 1
 */

using System;

namespace Class_work_1
{

    class Program
    {
        private int steve;
        public void setSteve(int s)
        {
            steve = s;
        }

        public int getSteve()
        {
            return steve;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadKey();
            Console.WriteLine("Setting Steve to 4");
            Program p = new Program();
            p.setSteve(4);
            Console.WriteLine("Steve is: " + p.getSteve());
            Console.ReadKey();
        }
    }
}
