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
                        PrintSeparator();
                        GradeCalculator();
                        break;
                    case "2":
                        PrintSeparator();
                        //TicketPriceCalculator();
                        break;
                    case "3":
                        PrintSeparator();
                        //TriangleTypeIdentifier();
                        break;
                    case "4":
                        Console.WriteLine("\nExiting the program... 👋🏼👋🏼👋🏼\n");
                        return;
                    default:
                        Console.WriteLine("\nInvalid choice. Please enter 1, 2, 3, or 4.\n");
                        break;
                }
                PrintSeparator();
            }
        }


        static void GradeCalculator()
        {
            while (true)
            {
                Console.Write("Enter a numerical grade between 0 and 100 (or type 'exit' to return to the main menu): ");
                string input = Console.ReadLine();

                if (input.ToLower() == "exit")
                {
                    return;
                }

                if (int.TryParse(input, out int grade))
                {
                    
                    if (grade >= 0 && grade <= 100)
                    {
                        
                        string letterGrade = grade switch
                        {
                            >= 90 => "A",
                            >= 80 => "B",
                            >= 70 => "C",
                            >= 60 => "D",
                            _ => "F"
                        };

           
                        Console.WriteLine($"The letter grade is: >> {letterGrade} \n");
                    }
                    else
                    {
                        Console.WriteLine("\n Error: The grade must be between 0 and 100.\n");
                    }
                }
                else
                {
                    Console.WriteLine("\n Error: Invalid input. Please enter a numerical grade.\n");
                }
            }
        }

        
        
        static void PrintSeparator()
        {
            Console.WriteLine(new string('-', 40));
        }
    }
}
