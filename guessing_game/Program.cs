using System;

namespace guessing_game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter random value:");
            int name = Int32.Parse(Console.ReadLine());
            Random x = new Random();
            int value = x.Next(1, 12);
            if(value==name)
            {
                Console.WriteLine("LUCKY");
            }
            else 
            {
                Console.WriteLine($"Loser random: {value}, Your value: {name}");
            }
              
        }
    }
}
