using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class Linq
    {
        private static void Main()
        {
            //the three parts of a linq query: differed execution
            //1. Data Source
            List<int> numbers = new List<int>();
            numbers.Add (110);
            numbers.Add(100);
            numbers.Add(105);
            numbers.Add(102);

            //2. Query creation. sql type
            //var numQuery = from num in numbers //select num from numbers
            //where num > 102
            //select num;  

            //lamda exp
            var numQuery = numbers.Where(x => x > 102);

           

            //Query execution

            foreach (int num in numQuery)
            {
                Console.Write("{0} ", num);
                //num.Dump(); //this is for LinQpad not for vs
            }
            Console.ReadLine();
        }
    }
}
