using System;
using System.Collections.Generic;

class BodyControlTracker
{
    static List<string> bodyControlLogs = new List<string>();

    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Body Control Tracker!");

        while (true)
        {
            Console.WriteLine("\nPlease select an option:");
            Console.WriteLine("1. Log losing control of your body and muscles");
            Console.WriteLine("2. Log tripping out experience");
            Console.WriteLine("3. View log history");
            Console.WriteLine("4. Exit");

            int choice = GetValidIntegerInput("Enter your choice: ");

            switch (choice)
            {
                case 1:
                    LogBodyControlIssue();
                    break;
                case 2:
                    LogTrippingOutExperience();
                    break;
                case 3:
                    ViewLogHistory();
                    break;
                case 4:
                    Console.WriteLine("Thank you for using the Body Control Tracker. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    static void LogBodyControlIssue()
    {
        Console.WriteLine("Please describe your experience of losing control of your body and muscles:");
        string logEntry = Console.ReadLine();
        bodyControlLogs.Add($"[Body Control] - {DateTime.Now}: {logEntry}");
        Console.WriteLine("Log recorded successfully.");
    }

    static void LogTrippingOutExperience()
    {
        Console.WriteLine("Please describe your tripping out experience:");
        string logEntry = Console.ReadLine();
        bodyControlLogs.Add($"[Tripping Out] - {DateTime.Now}: {logEntry}");
        Console.WriteLine("Log recorded successfully.");
    }

    static void ViewLogHistory()
    {
        Console.WriteLine("Log History:");
        if (bodyControlLogs.Count == 0)
        {
            Console.WriteLine("No logs recorded yet.");
        }
        else
        {
            foreach (string log in bodyControlLogs)
            {
                Console.WriteLine(log);
            }
        }
    }

    static int GetValidIntegerInput(string message)
    {
        int input;
        bool isValidInput;

        do
        {
            Console.Write(message);
            isValidInput = int.TryParse(Console.ReadLine(), out input);
            if (!isValidInput)
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        } while (!isValidInput);

        return input;
    }
}
