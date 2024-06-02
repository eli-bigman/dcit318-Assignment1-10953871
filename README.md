using System;

namespace dcit318_Project
{
    class GradeEvaluation
    {
        public static void EvaluateGrades()
        {
            while (true)
            {
                Console.Write("Please enter a grade between 0 and 100 (or type 'back' to go back to the main menu): ");
                string input = Console.ReadLine();

                if (input.ToLower() == "back")
                {
                    return;
                }

                if (int.TryParse(input, out int grade))
                {
                    if (grade >= 0 && grade <= 100)
                    {
                        string gradeLetter;
                        if (grade >= 90)
                        {
                            gradeLetter = "A";
                        }
                        else if (grade >= 80)
                        {
                            gradeLetter = "B";
                        }
                        else if (grade >= 70)
                        {
                            gradeLetter = "C";
                        }
                        else if (grade >= 60)
                        {
                            gradeLetter = "D";
                        }
                        else
                        {
                            gradeLetter = "F";
                        }

                        Console.WriteLine($"Your letter grade is: {gradeLetter}\n");
                    }
                    else
                    {
                        Console.WriteLine("\nError: The grade must be in the range 0-100.\n");
                    }
                }
                else
                {
                    Console.WriteLine("\nError: Invalid input. Please enter a valid numerical grade.\n");
                }
            }
        }
    }

    class TicketPriceCalculator
    {
        public static void CalculateTicketPrice()
        {
            while (true)
            {
                Console.Write("Please enter your age (or type 'back' to go back to the main menu): ");
                string input = Console.ReadLine();

                if (input.ToLower() == "back")
                {
                    return;
                }

                if (int.TryParse(input, out int age))
                {
                    int price = (age <= 12 || age >= 65) ? 7 : 10;
                    Console.WriteLine($"\nYour ticket price is: ${price}\n");
                }
                else
                {
                    Console.WriteLine("\nError: Invalid age input. Please enter a valid age.\n");
                }
            }
        }
    }

    class TriangleTypeChecker
    {
        public static void IdentifyTriangleType()
        {
            while (true)
            {
                Console.WriteLine("Please enter the lengths of the three sides of the triangle (or type 'back' to go back to the main menu):");

                Console.Write("Length of side 1: ");
                string input1 = Console.ReadLine();
                if (input1.ToLower() == "back") return;

                Console.Write("Length of side 2: ");
                string input2 = Console.ReadLine();
                if (input2.ToLower() == "back") return;

                Console.Write("Length of side 3: ");
                string input3 = Console.ReadLine();
                if (input3.ToLower() == "back") return;

                if (int.TryParse(input1, out int side1) && int.TryParse(input2, out int side2) && int.TryParse(input3, out int side3))
                {
                    if (side1 > 0 && side2 > 0 && side3 > 0)
                    {
                        if (side1 == side2 && side2 == side3)
                        {
                            Console.WriteLine("\nThe triangle is Equilateral.\n");
                        }
                        else if (side1 == side2 || side1 == side3 || side2 == side3)
                        {
                            Console.WriteLine("\nThe triangle is Isosceles.\n");
                        }
                        else
                        {
                            Console.WriteLine("\nThe triangle is Scalene.\n");
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nError: All side lengths must be positive numbers.\n");
                    }
                }
                else
                {
                    Console.WriteLine("\nError: Invalid input. Please enter valid numerical values for the sides.\n");
                }
            }
        }
    }

    class Utilities
    {
        public static void PrintDivider()
        {
            Console.WriteLine(new string('-', 40));
        }
    }

    class Application
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Grade Evaluation");
                Console.WriteLine("2. Ticket Price Calculation");
                Console.WriteLine("3. Triangle Type Identification");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    Utilities.PrintDivider();
                    GradeEvaluation.EvaluateGrades();
                }
                else if (choice == "2")
                {
                    Utilities.PrintDivider();
                    TicketPriceCalculator.CalculateTicketPrice();
                }
                else if (choice == "3")
                {
                    Utilities.PrintDivider();
                    TriangleTypeChecker.IdentifyTriangleType();
                }
                else if (choice == "4")
                {
                    Console.WriteLine("\nThank you for using the application. Goodbye!\n");
                    return;
                }
                else
                {
                    Console.WriteLine("\nInvalid choice. Please enter 1, 2, 3, or 4.\n");
                }

                Utilities.PrintDivider();
            }
        }
    }
}
