// See https://aka.ms/new-console-template for more information

// This is the namespace for my program 
namespace Mission2Brian_Stone
{
    // I saw someone else use this and I believe it just imports the system namespace? 
    using System;

    class Program
    {
        // Main entry point for the app, it will display a welcome message, prompt the user for the number of dice rolls to simulate, creates and instance of the Simulator class "DiceSimulator"
        // gets results from the simulator (found on Simulator.cs) prints the histogram and displays a goodbye message 
        static void Main()
        {
            Console.WriteLine("Welcome to the dice throwing simulator!");

            Console.Write("How many dice rolls would you like to simulate? ");
            int numRolls = int.Parse(Console.ReadLine());

            DiceSimulator simulator = new DiceSimulator();

            int[] results = simulator.SimulateRolls(numRolls);

            PrintHistogram(results, numRolls);

            Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
        }

        // This will print the histogram based on simulation results and total rolls, including a header, information about the % and asterisks, and total number of rolls 
        static void PrintHistogram(int[] results, int totalRolls)
        {
            Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
            Console.WriteLine($"Total number of rolls = {totalRolls}.");

            // This for loop will iterate through possible totals (2-12) and print asterisks based on percentage
            for (int i = 2; i <= 12; i++)
            {
                int percentage = (int)Math.Round((double)results[i] * 100 / totalRolls);
                Console.WriteLine($"{i}: {new string('*', percentage)}");
            }
        }


    }
}