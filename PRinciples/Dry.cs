using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principles
{
    public class Dry
    {
        public Dry()
        {
            //Looping through numbers to calc total
            double[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            double total = 0;

            foreach (double number in nums)
            {
                total += number;
            }

            Console.WriteLine(total);

            //Duplicated code
            double[] nums10s = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

            total = 0;

            foreach (double number in nums10s)
            {
                total += number;
            }

            Console.WriteLine(total);

            //Adhering to DRY principle
            Console.WriteLine(SumOfNums(nums));
            Console.WriteLine(SumOfNums(nums10s));

            //Adhere to the KISS principle
            Console.WriteLine(nums.Sum());
            Console.WriteLine(nums10s.Sum());

        }

        public double SumOfNums(double[] nums)
        {
            double total = 0;

            foreach (double number in nums)
            {
                total += number;
            }

            return total;
        }

    }
}
