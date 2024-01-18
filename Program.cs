// See https://aka.ms/new-console-template for more information

class DiceSimulator
{
    private static Random random = new Random();

    public int[] SimulateRolls(int numberOfRolls)
    {
        int[] results = new int[13];

        for (int i = 0; i < numberOfRolls; i++)
        {
            int roll1 = random.Next(1, 7);
            int roll2 = random.Next(1, 7);
            results[roll1 + roll2]++;
        }

        return results;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the dice throwing simulator 2000!");
        Console.Write("Enter the number of dice rolls you want to simulate: ");
        int numberOfRolls = int.Parse(Console.ReadLine());
        string sNumberOfRolls = numberOfRolls.ToString();

        Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
        Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
        Console.WriteLine("Total number of rolls = " + sNumberOfRolls);

        DiceSimulator simulator = new DiceSimulator();
        int[] results = simulator.SimulateRolls(numberOfRolls);

        for (int i = 2; i <= 12; i++)
        {
            Console.Write($"{i}: ");
            int percentage = results[i] * 100 / numberOfRolls;
            for (int j = 0; j < percentage; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}