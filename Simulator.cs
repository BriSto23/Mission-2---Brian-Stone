using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Once again this is the namespace (not sure if necessary for this program) 
namespace Mission2Brian_Stone
{
    using System;

    // This is the DiceSimulator class called in the Program.cs code, this class will first generate random numbers, simulate the rolling of two dice for a specified number of rolls, 
    // initialize and array to store the results for each possible total 
    class DiceSimulator
    {
        private Random random = new Random();

        public int[] SimulateRolls(int numRolls)
        {
            int[] results = new int[13]; // Index 0 is not used

            // This for loop will loop through the number of rolls, simulate the roll of the first die and second die and will calculate the sum of the two and return results 
            for (int counter = 0; counter < numRolls; counter++)
            {
                int die1 = random.Next(1, 7);
                int die2 = random.Next(1, 7);

                int sum = die1 + die2;

                results[sum]++;
            }

            return results;
        }
    }

}
