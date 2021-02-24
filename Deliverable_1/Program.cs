using System;

namespace Deliverable_1
{
    class Program
    {
        static void Main(string[] args)
        {

            
                Console.WriteLine("Please input measurement type. ");

                string measurementUnit = Console.ReadLine();

                Console.WriteLine("Please enter amount. ");
                long amount = long.Parse(Console.ReadLine());
                if (measurementUnit == "inch")
                {
                    Console.WriteLine(amount / .2857142857142857);
                }
                if (measurementUnit == "fidget spinner")
                {
                    Console.WriteLine(amount / 3.5);
                }
                if (measurementUnit == "memes")
                {
                    Console.WriteLine(amount / .2);
                }
                if (measurementUnit == "feet")
                {
                    Console.WriteLine(amount / 5);
                }
                Console.WriteLine("Would you like to try another conversion? yes/no");
                string again = Console.ReadLine();
            while (again == "yes")
            {

            }

          
            
            
            
                
            
            
                
            
        }
    }
}
