using System;
using System.Collections.Generic;
using System.Linq;

/* Monte Carlo Assignment - Jeffrey Washburn
 * 
 * The Monte Carlo method allows us to make estimations based on large samples of data, by sampling random and unbiased
 * subsets. For example, if we wanted to figure out the average height of every person in the world, we 
 * obviously wouldn't go around getting every single persons height, there are simply too many people in the world.
 * Instead, we can take a random group and average their height, hoping that it is close to the average of the whole
 * world. By taking samples from a larger and larger group, the accuracy generally increases.
 * A common use of the Monte Carlo method in programming is calculating the lighting of 3d space.
 * 
 */

namespace MonteCarloUnitCircleSimulation
{
    class MonteCarlo
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("\nEnter number of simulations [CTRL-C to exit]: ");
                if (!int.TryParse(Console.ReadLine(), out var simulationIterations))
                {
                    Console.WriteLine("Please enter a single, whole number.");
                    continue;
                }

                // Estimate area of a unit circle by getting ratio of pairs that overlapped circle and total pairs.
                // Coordinate pairs are randomly generated.
                var approximateArea = 4f * GeneratePairs(simulationIterations)
                    .Count(pair => pair.OverlapsCircle(1)) / simulationIterations;

                // Show results! 🔥
                Console.WriteLine($"\tApproximate area: {approximateArea}\n\t" +
                    $"Difference from PI: {Math.Abs(Math.PI - approximateArea)}");
            }
        }

        // Return a list of randomly generated coordinate pairs
        static IEnumerable<CoordinatePair> GeneratePairs(int numberPairs)
        {
            var pairs = new List<CoordinatePair>();

            for (var i = 0; i < numberPairs; i++)
            {
                var randomX = (float)new Random().NextDouble(); 
                var randomY = (float)new Random().NextDouble();

                pairs.Add(new CoordinatePair(randomX, randomY));
            }

            return pairs;
        }
    }
}