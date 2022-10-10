using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    public class Except
    {
        static void Sample_Except_Lambda()
        {
            int[] numbers1 = { 1, 2, 3 };
            int[] numbers2 = { 3, 4, 5 };

            var result = numbers1.Except(numbers2);

            Console.WriteLine("Except creates a single sequence from numbers1 and removes the duplicates found in numbers2:");
            foreach (int number in result)
                Console.WriteLine(number);
        }
    }
}
