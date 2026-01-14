namespace Mission2;

public class DiceRoller
{
    // Simulating rolling two six-diced dice a specified number of time
    // Returns an array containing the frequency of each possible sum
    public int[] RollDice(int NumberOfRolls)
    {
        // Array store the count of each dice total
        int[] results = new int[13];
        System.Console.WriteLine(results);
        
        // Random number generator for dice rolls
        Random rand = new Random();

        // Roll the dice the specified number of times
        for (int i = 0; i < NumberOfRolls; i++)
        {
            // generate two random dice values (1-6)
            int die1 = rand.Next(1, 7);
            int die2 = rand.Next(1, 7);
            
            // Sum of the two dice
            int sum = die1 + die2;

            // Increment the count for this dice total
            results[sum]++;
        }
        // Return array with rolling results
        return results;
    }
}