using System;

namespace ExponentialGrowthModel
{
    class Program
    {
        static void Main(string[] args)
        {
            double initialPopulation = 100; // Initial population size
            double growthRate = 0.02; // Growth rate (percentage in decimal format)
            int numberOfPeriods = 10; // Number of periods to project

            Console.WriteLine("Exponential Growth Model");
            Console.WriteLine($"Initial Population: {initialPopulation}");
            Console.WriteLine($"Growth Rate: {growthRate * 100}%");
            Console.WriteLine($"Number of Periods: {numberOfPeriods}");

            for (int period = 1; period <= numberOfPeriods; period++)
            {
                double projectedPopulation = CalculateProjectedPopulation(initialPopulation, growthRate, period);
                Console.WriteLine($"Period {period}: {projectedPopulation:F2}");
            }
        }

        static double CalculateProjectedPopulation(double initialPopulation, double growthRate, int numberOfPeriods)
        {
            return initialPopulation * Math.Pow(1 + growthRate, numberOfPeriods);
        }
    }
}
