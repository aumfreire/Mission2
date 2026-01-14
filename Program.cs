// See https://aka.ms/new-console-template for more information
using Mission2;

internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the dice throwing simulator!");
        System.Console.Write("How many dice rolls would you like to simulate? ");
        
        int rolls = int.Parse(Console.ReadLine());

        DiceRoller roller = new DiceRoller();
        int[] results = roller.RollDice(rolls);
        
        Console.WriteLine("\nDICE ROLLING SIMULATOR RESULTS");
        Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
        Console.WriteLine($"Total number of rolls = {rolls}.\n");

        for (int i = 2; i <= 12; i++)
        {
            int percentage = (results[i] * 100) / rolls;
            
            Console.Write($"{i}: ");
            for (int j = 0; j < percentage; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        } 
        Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
    }
}