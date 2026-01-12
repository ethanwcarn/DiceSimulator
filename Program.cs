// Ethan Carn IS 413 Dice rolling simulator 
// using system and namespace just set up default needs
using System;

namespace DiceRollingSimulator
{
    class Program
    {
        // Pass an empty string
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the dice throwing simulator!");
            Console.Write("How many dice rolls would you like to simulate? ");

            // set number of rolls as a number based on user input 
            int numberOfRolls = int.Parse(Console.ReadLine());

            // Create simulator and run rolls
            DiceSimulator simulator = new DiceSimulator();
            int[] results = simulator.RollDice(numberOfRolls);

            Console.WriteLine();
            Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
            Console.WriteLine($"Total number of rolls = {numberOfRolls}.");
            Console.WriteLine();

            // Results array index 0 corresponds to roll total of 2
            // The for loop will continue for as many rolls the user said to complete
            for (int i = 0; i < results.Length; i++)
            {
                int rollTotal = i + 2;
                int percentage = (int)Math.Round((double)results[i] / numberOfRolls * 100);

                //formatting for how the rolls will appear 
                Console.Write($"{rollTotal}: ");
                Console.WriteLine(new string('*', percentage));
            }

            Console.WriteLine();
            Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
        }
    }
}
