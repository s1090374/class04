using System;

namespace class04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                Console.Write($"The factors of {number}: ");
                FindFactors(number);
            }
            else
            {
                Console.WriteLine("無效輸入，請輸入一個整數。");
            }
        }

        static void FindFactors(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    Console.Write(i);
                    if (i < number)
                    {
                        Console.Write(",");
                    }
                }
            }
            Console.WriteLine(); 
        }
    }
}
    