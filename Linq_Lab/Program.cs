using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 10, 2330, 112233, 12, 949, 3764, 2942, 523863 };

            Console.WriteLine($"The minimum number is {nums.Min()}\n");

            Console.WriteLine($"The maximum number is {nums.Max()}\n");

            var numsDescend = nums.OrderByDescending(x => x);
            var maxUnder10k = numsDescend.FirstOrDefault(aNum => aNum < 10000);
            Console.WriteLine($"The maximum number under 10000 is {maxUnder10k}\n");


            var smallRange = nums.Where(aNum => aNum > 10 && aNum < 100);
            Console.WriteLine("The numbers between 10 and 100 are:");
            foreach (int aNum in smallRange)
            {
                Console.WriteLine(aNum);
            }

            var bigRange = nums.Where(aNum => aNum >= 100000 && aNum <= 999999);
            Console.WriteLine("\nThe numbers between 100000 and 999999 inclusive are:");
            foreach (int aNum in bigRange)
            {
                Console.WriteLine(aNum);
            }

            var evenNums = nums.Where(aNum => aNum%2 == 0);
            Console.WriteLine($"\nThere are {evenNums.Count()} even numbers.");
            Console.WriteLine("The even numbers are:");
            foreach (int aNum in evenNums)
            {
                Console.WriteLine(aNum);
            }
        }
    }
}
