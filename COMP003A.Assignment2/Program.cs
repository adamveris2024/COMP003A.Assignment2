using System.Globalization;

namespace COMP003A.Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            string lastName;
            int userAge;
            double itemPrice;
            bool isStudent;

            Console.WriteLine("********************************************************");
            Console.WriteLine("Welcome to Discount Calculator!");
            Console.WriteLine("********************************************************\n");

            Console.Write("Enter your first name: ");
            firstName = Console.ReadLine();

            Console.Write("Enter your last name: ");
            lastName = Console.ReadLine();

            Console.Write("What is your age: ");
            userAge = int.Parse(Console.ReadLine());

            Console.Write("What is the price of the item you're interested in: ");
            itemPrice= double.Parse(Console.ReadLine());

            Console.Write("Are you a student? (true/false): ");
            isStudent = bool.Parse(Console.ReadLine());

            Console.WriteLine("\n");
            Console.WriteLine("\n");


            int futureAge = userAge + 5;
            double studPrice = itemPrice * 0.9;
            double srPrice = itemPrice * 0.8;


            Console.WriteLine("********************************************************");
            Console.WriteLine($"Hello, " + firstName + " " + lastName + "!");
            Console.WriteLine($"Your current age is " + userAge + ".");
            Console.WriteLine($"In 5 years, you will be " + futureAge);
            Console.WriteLine($"The original price of the item is $" + itemPrice);
            Console.WriteLine($"As a student, your discounted price is $" + studPrice);
            Console.WriteLine($"As a senior citizen, your discounted price is $" + srPrice);
            Console.WriteLine("********************************************************");


        }
    }
}