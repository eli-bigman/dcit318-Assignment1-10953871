namespace dcit318_Assignment1
{
    using System;
    using System.Diagnostics;

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
                        TicketPriceCalculator();
                        break;
                    case "3":
                        PrintSeparator();
                        TriangleTypeIdentifier();
                        break;
                    case "4":
                        Console.WriteLine("\nExiting the program...\n");
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

        static void TicketPriceCalculator()
        {
            while (true)
            {
                Console.WriteLine("Enter your age (or type 'exit' to return to the main menu):");
                string input = Console.ReadLine();

                if (input.ToLower() == "exit")
                {
                    return;
                }

                
                if (int.TryParse(input, out int age))
                {

                    int ticketPrice = (age <= 12 || age >= 65) ? 7 : 10;

                    


                    Console.WriteLine($"\nThe ticket price is >> GHC{ticketPrice}\n");
                }
                else
                {
                    Console.WriteLine("\nError: Invalid input. Please enter a valid age.");
                }
            }
        }


        static void TriangleTypeIdentifier()
        {
            while (true)
            {
                Console.WriteLine("Enter the lengths of the three sides of the triangle (or type 'exit' to return to the main menu):");

                Console.Write("\nSide 1: ");
                string input1 = Console.ReadLine();
                if (input1.ToLower() == "exit") return;

                Console.Write("\nSide 2: ");
                string input2 = Console.ReadLine();
                if (input2.ToLower() == "exit") return;

                Console.Write("\nSide 3: ");
                string input3 = Console.ReadLine();
                if (input3.ToLower() == "exit") return;

                if (int.TryParse(input1, out int side1) && int.TryParse(input2, out int side2) && int.TryParse(input3, out int side3))
                {
                    if (side1 > 0 && side2 > 0 && side3 > 0)
                    {
                        if (side1 == side2 && side2 == side3)
                        {
                            Console.WriteLine("\nThe triangle is Equilateral.");
                        }
                        else if (side1 == side2 || side1 == side3 || side2 == side3)
                        {
                            Console.WriteLine("\nThe triangle is Isosceles.");
                        }
                        else
                        {
                            Console.WriteLine("\nThe triangle is Scalene.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nError: The sides must be positive numbers.\n");
                    }
                }
                else
                {
                    Console.WriteLine("Error: Invalid input. Please enter valid numbers for the sides.");
                }
            }
        }


        static void PrintSeparator()
        {
            Console.WriteLine(new string('-', 40));
        }
    }
}
