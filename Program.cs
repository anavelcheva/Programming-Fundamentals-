using System;
using System.Linq;

namespace ArrayStatistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int min = int.MaxValue;
            int max = int.MinValue;
            int sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                sum += input[i];
                min = Math.Min(input[i], min);
                max = Math.Max(input[i], max);
            }

            double average = (double)sum / input.Length;
            Console.WriteLine($"Min = {min}");
            Console.WriteLine($"Max = {max}");
            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Average = {average}");
        }
    }
}
