// See https://aka.ms/new-console-template for more information
// Creed Garner
// 1/17/2024
// Dice Rolling Simulator - IS 413 Mission 02
// This program simulates the rolling of two dice a user-specified number of times.

// this class is the main program
class Program
{
    static void Main(string[] args)
    {
        //Intro and gets user input for number of rolls
        Console.WriteLine("Welcome to the dice throwing simulator 2000!");
        Console.Write("Enter the number of dice rolls you want to simulate: ");
        int numberOfRolls = int.Parse(Console.ReadLine());
        // String version of number of rolls for later use in output
        string sNumberOfRolls = numberOfRolls.ToString();

        Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
        Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
        Console.WriteLine("Total number of rolls = " + sNumberOfRolls);
        // Creates a new instance of the DiceSimulator class
        DiceSimulator simulator = new DiceSimulator();
        // Calls the SimulateRolls method from the DiceSimulator class
        int[] results = simulator.SimulateRolls(numberOfRolls);

        // Prints out the results of the simulation from the results array
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