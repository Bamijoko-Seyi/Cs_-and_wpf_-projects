// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        bool exit = false;
        while (exit == false)
        {
            Console.Write("Please enter the word you want to check: ");
            string user_input = Console.ReadLine();

            if (palindrome_checker(user_input) == true)
            {
                Console.WriteLine("It is a palindrome");
            }
            else
            {
                Console.WriteLine("It is not palindrome");
            }
            Console.Write("Do you want to exit (y/n): ");
            user_input = Console.ReadLine();

            if (user_input == "y")
            {
                exit = true;
            }

        }

    }
    static bool palindrome_checker(string word)
    {
        char[] original_word = word.ToCharArray();
        Array.Reverse(original_word);
        string reversed = new string(original_word);
        return word.Equals(reversed, StringComparison.OrdinalIgnoreCase);
    }
}