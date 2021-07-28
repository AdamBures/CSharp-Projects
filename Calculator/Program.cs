using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = new String('*', 28);

            bool check = true;

            Console.WriteLine(result);
            Console.WriteLine("*\t Calculator \t   *");
            Console.WriteLine(result);

            while (check == true)
            {
                Console.WriteLine("Enter number: ");
                float a = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter number: ");
                float b = float.Parse(Console.ReadLine());
                Console.WriteLine("Choose what you want to do: ");
                Console.WriteLine("1 - Addition");
                Console.WriteLine("2 - Subtraction");
                Console.WriteLine("3 - Multiplication");
                Console.WriteLine("4 - Division");

                int choice = int.Parse(Console.ReadLine());
                float equation_result = 0;
                string final_choice;

                switch (choice)
                {
                    case 1:
                        equation_result = a + b;
                        break;
                    case 2:
                        equation_result = a - b;
                        break;
                    case 3:
                        equation_result = a * b;
                        break;
                    case 4:
                        equation_result = a / b;
                        break;
                }
                Console.WriteLine("The result is {0}", equation_result);
                Console.WriteLine("Do you wish to continue [y/n]");
                final_choice = Console.ReadLine();

                if (final_choice == "y" || final_choice == "Y")
                {
                    check = true;
                }

                else
                {
                    Console.WriteLine("Thanks for using my program. Program will turn off in 5 seconds!");
                    System.Threading.Thread.Sleep(5000);
                    break;
                }
            }
        }
    }
}
