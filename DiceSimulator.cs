using System;

namespace DiceRollingSimulator
{
    class DiceSimulator
    {
        public int[] RollDice(int numberOfRolls)
        {
            int[] rollResults = new int[11]; // indices 0–10 represent totals 2–12
            Random random = new Random();

            for (int i = 0; i < numberOfRolls; i++)
            {
                int die1 = random.Next(1, 7);
                int die2 = random.Next(1, 7);
                int total = die1 + die2;

                rollResults[total - 2]++;
            }

            return rollResults;
        }
    }
}
