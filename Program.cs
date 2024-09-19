using System;
/*

namespace Foreachloop
{
    
    class foreachloop
    {
        static void Main(string[] args)
        {

            int number, result, range;
            string operatorChoice, again, add,sub,minus,div;

            do
            {
                Console.WriteLine("Enter a number: ");
                number = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the operator (+,-,*,/)");
                operatorChoice = Console.ReadLine();

                switch (operatorChoice)
                {
                    case "+":
                        add = "added";
                        Console.WriteLine("How many times do you want it to be added?");
                        break;
                    case "-":
                        sub = "subtracted";
                        Console.WriteLine("How many times do you want it to be subracted?");
                        break;
                    case "*":
                        minus = "multiplied";
                        Console.WriteLine("How many times do you want it to be multiplied?");
                        break;
                    case "/":
                        div = "divided";
                        Console.WriteLine("How many times do you want it to be divided?");
                        break;

                }     range = int.Parse(Console.ReadLine());


                switch (operatorChoice)
                {
                    case "+":

                        for (int i = 1; i <= range; i++)
                        {
                            result = number + i;
                            Console.WriteLine($"{number} + {i} = {result}");
                        }
                        break;

                    case "-":

                        for (int i = 1; i <= range; i++)
                        {
                            result = number - i;
                            Console.WriteLine($"{number} - {i} = {result}");
                        }
                        break;

                    case "*":

                        for (int i = 1; i <= range; i++)
                        {
                            result = number * i;
                            Console.WriteLine($"{number} * {i} = {result}");
                        }
                        break;

                    case "/":
                        for (int i = 1; i <= range; i++)
                        {
                            result = number / i;
                            Console.WriteLine($"{number} / {i} = {result}");
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid Operator");
                        break;

                }


                Console.WriteLine();
                Console.WriteLine("Do you want to perform another calculation? (yes/no) :  ");
                again = Console.ReadLine().ToLower();
                Console.Clear();


            } while (again == "yes");

            Console.WriteLine("Thank you for using!");
        } 
    }
} */