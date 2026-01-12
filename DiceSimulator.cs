using System;

namespace DiceRollingSimulator
{
    class DiceSimulator
    {
        // number of rolls taken from program.cs 
        public int[] RollDice(int numberOfRolls)
        {
            int[] rollResults = new int[11]; // indices 0–10 represent totals 2–12
            Random random = new Random();

            // After getting a random number for each die, add them up
            for (int i = 0; i < numberOfRolls; i++)
            {
                int die1 = random.Next(1, 7);
                int die2 = random.Next(1, 7);
                int total = die1 + die2;

                rollResults[total - 2]++;
            }
            //return the results
            return rollResults;
        }
    }
}
