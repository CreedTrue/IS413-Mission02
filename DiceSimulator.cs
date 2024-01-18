using System;
//The DiceSimulator class
// this class does the actual simulation
class DiceSimulator
{
    private static Random random = new Random();

    public int[] SimulateRolls(int numberOfRolls)
    {
        int[] results = new int[13];

        // roll the dice the specified number of times
        for (int i = 0; i < numberOfRolls; i++)
        {
            // roll the dice for a random number between 1 and 6
            int roll1 = random.Next(1, 7);
            int roll2 = random.Next(1, 7);
            // increment the appropriate result
            results[roll1 + roll2]++;
        }

        return results;
    }
}