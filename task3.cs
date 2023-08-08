using System;

namespace First_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
 Firstline: Console.Write("First number:");
            string firstInput = Console.ReadLine();
            int parsedFirstInput = int.Parse(firstInput);

            if (parsedFirstInput <= 0)
            {
                Console.WriteLine("Wrong input");
                goto Firstline;
            }


            Console.Write("Second number:");
            string secondInput = Console.ReadLine();
            int parsedSecondInput = int.Parse(secondInput);

            if (parsedFirstInput >= parsedSecondInput || parsedSecondInput <= 0)
            {
                Console.WriteLine("Wrong input");
                goto Firstline;
            }

            int count = 0;
            bool isTerminated = false;

            for (int i = parsedFirstInput; i < parsedSecondInput; i++)
            {
                if (i * 2 == parsedSecondInput)
                {
                    continue;
                }
                if (i * i == parsedSecondInput)
                {
                    Console.WriteLine($"Process terminated at {i}");
                    isTerminated = true;
                    break;
                }
                if (i % 2 == 1)
                {
                    count++;
                }

            }

            if (isTerminated == false)
            {
                Console.WriteLine(count);
            }

        }
    }    
}
