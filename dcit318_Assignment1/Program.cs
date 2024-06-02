namespace dcit318_Assignment1
{
    using System;

    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Select a program to run:");
                Console.WriteLine("1. Grade Calculator");
                Console.WriteLine("2. Ticket Price Calculator");
                Console.WriteLine("3. Triangle Type Identifier");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        //PrintSeparator();
                        //GradeCalculator();
                        break;
                    case "2":
                        //PrintSeparator();
                        //TicketPriceCalculator();
                        break;
                    case "3":
                        //PrintSeparator();
                        //TriangleTypeIdentifier();
                        break;
                    case "4":
                        Console.WriteLine("Exiting the program... 👋🏼👋🏼👋🏼");
                        return;
                    default:
                        Console.WriteLine("❌ ❌ Invalid choice. Please enter 1, 2, 3, or 4.");
                        break;
                }
                //PrintSeparator();
            }
        }


    }
}
