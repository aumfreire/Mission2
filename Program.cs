// See https://aka.ms/new-console-template for more information
using Mission2;

internal class Program
{
    public static void Main(string[] args)
    {
        // message to the user
        Console.WriteLine("Welcome to the dice throwing simulator!");
        System.Console.Write("How many dice rolls would you like to simulate? ");
        
        // read and convert number of rolls entered by the user
        int rolls = int.Parse(Console.ReadLine());

        // call DiceRoller class (simulate dice rolls)
        DiceRoller roller = new DiceRoller();
        int[] results = roller.RollDice(rolls);
        
        // display results
        Console.WriteLine("\nDICE ROLLING SIMULATOR RESULTS");
        Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
        Console.WriteLine($"Total number of rolls = {rolls}.\n");

        // print histogram (looping through all possible dice sums (2-12))
        for (int i = 2; i <= 12; i++)
        {
            // percentage calculation (times this sum was rolled)
            int percentage = (results[i] * 100) / rolls;
            
            // display dice number
            Console.Write($"{i}: ");
            
            // print one "*" per percentage point
            for (int j = 0; j < percentage; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        } 
        Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
    }
}