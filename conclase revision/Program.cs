using System;

namespace conclase_revision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("select  a number:");

            string userInput = Console.ReadLine();

            int userNumber = int.Parse(userInput);

            for (int i = 1; i <= userNumber; i++)
            {
                Console.Write(i + " ");

                int remainder = i % 2;

                if (remainder == 0)
                {
                    if (i == 4)
                    {
                        Console.WriteLine($"Welcome to {i}");
                    }
                    else if (i == 8)
                    {
                        Console.WriteLine($"Welcome to {i}");
                    }
                    else
                    {
                        Console.WriteLine($"The number is neither 4 nor 8: {i}");
                    }
                }
            }
        }
    }
}


