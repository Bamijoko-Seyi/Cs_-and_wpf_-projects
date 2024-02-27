// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        bool exit = false;
        while (exit == false)
        {
            Console.Write("Please enter a number: ");
            int user_input = int.Parse(Console.ReadLine());
            for (int i = 1; i <= user_input; i++)
            {
                if (((i % 3) == 0) && ((i % 5) == 0))
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if ((i % 3) == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            Console.Write("Do you want to quit (y/n): ");
            string input = Console.ReadLine();
            if(input == "y")
            {
                exit = true;
            }
        }
    }
}
