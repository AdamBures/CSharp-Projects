using System;

namespace NumberGuessing
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = new String('*', 28);

            Console.WriteLine(result);
            Console.WriteLine("*       Number Guesser    *");
            Console.WriteLine(result);

            bool check = true;

            while (check)
            {

                Console.WriteLine("\nEnter number to guess from: ");
                int start_number = int.Parse(Console.ReadLine());
                Console.WriteLine("\nEnter number to guess from: ");
                int end_number = int.Parse(Console.ReadLine());

                if (start_number < end_number)
                {
                    bool playing = true;
                    int number = new Random().Next(start_number, end_number);
                    while (playing)
                    {
                        Console.WriteLine("\nGuess the number from {0} to {1}", start_number, end_number);
                        int guess = int.Parse(Console.ReadLine());
                        int tries = 0;
                        Console.WriteLine("{0}", number);
                        if (guess > number)
                        {
                            Console.WriteLine("Guess too high");
                            tries += 1;

                        }

                        if (guess < number)
                        {
                            Console.WriteLine("Guess too low");
                            tries += 1;
                        }

                        if (guess == number)
                        {
                            Console.WriteLine("You found it!");
                            break;
                        }

                        if (tries == 3)
                        {
                            Console.WriteLine("You've lost :((");
                            playing = false;
                            break;
                        }

                    }
                }
                else
                {
                    Console.WriteLine("\nSecond number must be bigger than first!!");

                }
            }
        }
    }
}