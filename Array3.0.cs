using System;

/*
namespace TrainingCodes
{
    
    internal class Array3
    {
        static void Main(string[] args)
        {
            string name, secGrd;
            int subNumbers;
            decimal average = 0;
            decimal total = 0;
            decimal grade = 0;
         
            Console.Write("Enter your name: ");
            name = Console.ReadLine();
            Console.Write("Enter your Grade & Section: ");
            secGrd = Console.ReadLine();
            Console.Write("Enter how many subjects do you currently have: ");
            subNumbers = Convert.ToInt32(Console.ReadLine());

            string[] subject = new string[subNumbers];

            for (int i = 0; i < subNumbers; i++)
            {
                Console.Write($"Enter subject number " + (i + 1) + ":");
                subject[i] = Console.ReadLine();


            }

            for (int i = 0; i < subNumbers; i++)
            {
                Console.Write($"Enter " + (subject[i]) + " grade:");
                grade = Convert.ToInt32(Console.ReadLine());

                    total += grade;
                
            }
                average = total / subNumbers;
            
                Console.WriteLine("Hi there!" + name + "." + "So you're a " + secGrd + ".Taking the following subject:");
                Console.WriteLine(string.Join(", ", subject) + ".");
                Console.WriteLine("Your final grade is " + (average));
                Console.WriteLine(" We wish you the best in passing all of these!");
            
        }
    }
}
*/