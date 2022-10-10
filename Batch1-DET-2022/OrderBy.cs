using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class OrderBy
    {
        //public  static void Main()
        // {
        //     int[] numbers = { 7, 9, 5 };

        //     var result = numbers.OrderBy(n => n);

        //    Console.WriteLine("Ordered list of numbers:");
        //     foreach (int number in result)
        //         Console.WriteLine(number);
        // }
        //static void Main()
        //{
        //    char[] characters = { 's', 'a', 'm', 'p', 'l', 'e' };

        //    var result = characters.Reverse();

        //    Console.WriteLine("Characters in reverse order:");
        //    foreach (char character in result)
        //        Console.WriteLine(character);
        //}
        //static void Main()
        //{
        //    string[] capitals = { "Berlin", "Paris", "Madrid", "Tokyo", "London",
        //                  "Athens", "Beijing", "Seoul" };

        //    var result = capitals.OrderBy(c => c.Length).ThenBy(c => c);

        //    Console.WriteLine("Ordered list of capitals, first by length and then alphabetical:");
        //    foreach (string capital in result)
        //        Console.WriteLine(capital);
        //}
        //    static void Main()
        //    {
        //        var dates = new DateTime[] {
        //    new DateTime(2015, 3, 1),
        //    new DateTime(2014, 7, 1),
        //    new DateTime(2013, 5, 1),
        //    new DateTime(2015, 1, 1),
        //    new DateTime(2015, 7, 1)
        //};

        //        var result = dates.OrderByDescending(d => d.Year).ThenByDescending(d => d.Month);

        //        Console.WriteLine("List of dates first ordered by year descending, and then by month descending:");
        //        foreach (DateTime dt in result)
        //            Console.WriteLine(dt.ToString("yyyy/MM/dd"));
        //    }




        //    static void Main()
        //    {
        //        string[] words = { "one", "two", "three", "four", "five", "six" };

        //        var result = words.Skip(4);

        //        Console.WriteLine("Skips the first 4 words:");
        //        foreach (string word in result)
        //            Console.WriteLine(word);
        //    }



        //static void Main()
        //{
        //    string[] words = { "one", "two", "three", "four", "five", "six" };

        //    var result = words.SkipWhile(w => w.Length == 3);

        //    Console.WriteLine("Skips words while the condition is met:");
        //    foreach (string word in result)
        //        Console.WriteLine(word);
        //}





        //    static void Main()
        //    {
        //        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        //        var result = numbers.Take(5);

        //        Console.WriteLine("Takes the first 5 numbers only:");
        //        foreach (int number in result)
        //            Console.WriteLine(number);
        //    }



        //static void Main()
        //{
        //    int[] numbers = { 1, 2, 2, 3, 5, 6, 6, 6, 8, 9 };

        //    var result = numbers.Distinct();

        //    Console.WriteLine("Distinct removes duplicate elements:");
        //    foreach (int number in result)
        //        Console.WriteLine(number);
        //}



        //static void Main()
        //{
        //    int[] numbers1 = { 1, 2, 3 };
        //    int[] numbers2 = { 3, 4, 5 };

        //    var result = numbers1.Intersect(numbers2);

        //    Console.WriteLine("Intersect creates a single sequence with only the duplicates:");
        //    foreach (int number in result)
        //        Console.WriteLine(number);
        //}


        //static void Main()
        //{
        //    int[] numbers1 = { 1, 2, 3 };
        //    int[] numbers2 = { 3, 4, 5 };

        //    var result = numbers1.Union(numbers2);

        //    Console.WriteLine("Union creates a single sequence and eliminates the duplicates:");
        //    foreach (int number in result)
        //        Console.WriteLine(number);
        //}



        //{
        //    string[] words = { "One", "Two", "Three" };

        //    var result = words.ElementAt(1);

        //    Console.WriteLine("Element at index 1 in the array is:");
        //    Console.WriteLine(result);
        //}





        //{
        //    string[] colors = { "Red", "Green", "Blue" };

        //    var resultIndex1 = colors.ElementAtOrDefault(1);

        //   var resultIndex10 = colors.ElementAtOrDefault(10);

        //   Console.WriteLine("Element at index 1 in the array contains:");
        //   Console.WriteLine(resultIndex1);

        //  Console.WriteLine("Element at index 10 in the array does not exist:");
        //   Console.WriteLine(resultIndex10 == null);
        //}





        //{
        //    string[] fruits = { "Banana", "Apple", "Orange" };

        //    var result = fruits.First();

        //    Console.WriteLine("First element in the array is:");
        //    Console.WriteLine(result);
        //}




        //{
        //    string[] countries = { "Denmark", "Sweden", "Norway" };

        //    var result = countries.First(c => c.Length == 6);

        //    Console.WriteLine("First element with a length of 6 characters:");
        //    Console.WriteLine(result);
        //}



        //{
        //    string[] countries = { "Denmark", "Sweden", "Norway" };
        //    string[] empty = { };

        //    var result = countries.FirstOrDefault();

        //    var resultEmpty = empty.FirstOrDefault();

        //    Console.WriteLine("First element in the countries array contains:");
        //    Console.WriteLine(result);

        //    Console.WriteLine("First element in the empty array does not exist:");
        //    Console.WriteLine(resultEmpty == null);
        //}





        //{
        //    int[] numbers = { 7, 3, 5 };

        //    var result = numbers.Last();

        //    Console.WriteLine("Last number in array is:");
        //    Console.WriteLine(result);
        //}






        //{
        //    string[] words = { "one", "two", "three" };
        //    string[] empty = { };

        //    var result = words.LastOrDefault();

        //    var resultEmpty = empty.LastOrDefault();

        //    Console.WriteLine("Last element in the words array contains:");
        //    Console.WriteLine(result);

        //    Console.WriteLine("Last element in the empty array does not exist:");
        //    Console.WriteLine(resultEmpty == null);
        //}





        //{
        //    string[] words = { "one", "two", "three" };

        //    var result = words.LastOrDefault(w => w.Length == 3);

        //    var resultNoMatch = words.LastOrDefault(w => w.Length == 2);

        //    Console.WriteLine("Last element in the words array having a length of 3:");
        //    Console.WriteLine(result);

        //    Console.WriteLine("Last element in the empty array having a length of 2 does not exist:");
        //    Console.WriteLine(resultNoMatch == null);
        //}






        //{
        //    string[] names1 = { "Peter" };
        //    string[] names3 = { "Peter", "Joe", "Wilma" };
        //    string[] empty = { };

        //    var result1 = names1.Single();

        //    Console.WriteLine("The only name in the array is:");
        //    Console.WriteLine(result1);

        //    try
        //    {
        //        // This will throw an exception because array contains no elements
        //        var resultEmpty = empty.Single();
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.Message);
        //    }

        //    try
        //    {
        //        // This will throw an exception as well because array contains more than one element
        //        var result3 = names3.Single();
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.Message);
        //    }
        //}




        //{
        //    string[] names1 = { "Peter" };
        //    string[] names3 = { "Peter", "Joe", "Wilma" };
        //    string[] empty = { };

        //    var result1 = names1.SingleOrDefault();

        //    var resultEmpty = empty.SingleOrDefault();

        //    Console.WriteLine("The only name in the array is:");
        //    Console.WriteLine(result1);

        //    Console.WriteLine("As array is empty, SingleOrDefault yields null:");
        //    Console.WriteLine(resultEmpty == null);

        //    try
        //    {
        //        // This will throw an exception as well because array contains more than one element
        //        var result3 = names3.SingleOrDefault();
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.Message);
        //    }
        //}




        //{
        //    var numbers = new int[] { 1, 2, 3, 4, 5 };

        //    var result = numbers.Aggregate((a, b) => a * b);

        //    Console.WriteLine("Aggregated numbers by multiplication:");
        //    Console.WriteLine(result);
        //}



        //{
        //    var numbers = new int[] { 1, 2, 3 };

        //    var result = numbers.Aggregate(10, (a, b) => a + b);

        //    Console.WriteLine("Aggregated numbers by addition with a seed of 10:");
        //    Console.WriteLine(result);
        //}




        //{
        //    int[] numbers = { 10, 10, 11, 11 };

        //    var result = numbers.Average();

        //    Console.WriteLine("Average is:");
        //    Console.WriteLine(result);
        //}


        //{
        //    string[] names = { "Peter", "John", "Kathlyn", "Allen", "Tim" };

        //    var result = names.Count();

        //    Console.WriteLine("Counting names gives:");
        //    Console.WriteLine(result);
        //}



        //{
        //    // Create array which is 5 elements larger than Int32.MaxValue
        //    var largeArr = Enumerable.Range(0, Int32.MaxValue).Concat(Enumerable.Range(0, 5));

        //    Int64 result = largeArr.LongCount();

        //    Console.WriteLine("Counting largeArr elements:");
        //    Console.WriteLine(result);
        //}




        //{
        //    int[] numbers = { 2, 8, 5, 6, 1 };

        //    var result = numbers.Max();

        //    Console.WriteLine("Highest number is:");
        //    Console.WriteLine(result);
        //}


        //{
        //    int[] numbers = { 6, 9, 3, 7, 5 };

        //    var result = numbers.Min();

        //    Console.WriteLine("Lowest number is:");
        //    Console.WriteLine(result);
        //}




        //{
        //    int[] numbers = { 2, 5, 10 };

        //    var result = numbers.Sum();

        //    Console.WriteLine("Summing the numbers yields:");
        //    Console.WriteLine(result);
        //}




        //{
        //    string[] names = { "Bob", "Ned", "Amy", "Bill" };

        //    var result = names.All(n => n.StartsWith("B"));

        //    Console.WriteLine("Does all of the names start with the letter 'B':");
        //    Console.WriteLine(result);
        //}




        //{
        //    string[] names = { "John", "Peter","Jacob", "Harry", "Jackson" };

        //    var result = names.Where(n => n.Contains("o"));

        //    Console.WriteLine("Does any of the names contain  the letter 'o':");
        //    Console.WriteLine(result);
        //}



        //{
        //    int[] numbers = { 1, 3, 5, 7, 9 };

        //    var result = numbers.Contains(5);

        //    Console.WriteLine("sequence contains the value 5:");
        //    Console.WriteLine(result);
        //}




        //{
        //    decimal[] numbers = { 3.4M, 8.33M, 5.225M };

        //    var result = numbers.Select(n => Math.Floor(n));

        //    Console.WriteLine("Numbers rounded down:");
        //    foreach (int number in result)
        //        Console.WriteLine(number);
        //}


        //{
        //    double[] angles = { 30D, 60D, 90D }; // Angles in radians

        //    var result = angles.Select(a => new { Angle = a, Cos = Math.Cos(a), Sin = Math.Sin(a) });

        //    Console.WriteLine("Calculated values:");
        //    foreach (var res in result)
        //        Console.WriteLine(String.Format("Angle {0}: Cos = {1}, Sin = {2}", res.Angle, res.Cos, res.Sin));
        //}




        //{
        //    string[] words = { "one", "two", "three" };

        //    var result = words.Select((w, i) => new
        //    {
        //        Index = i,
        //        Value = w
        //    });

        //    Console.WriteLine("Words with index and value:");
        //    foreach (var word in result)
        //        Console.WriteLine(String.Format("Index {0} is {1}", word.Index, word.Value));
        //}







        //{
        //    string[] characters = { 'blueberry', 'blackberry', 'abacus' };

        //        var result = characters.Reverse();

        //        Debug.WriteLine("Characters in reverse order:");
        //        foreach (string character in result)
        //            Debug.WriteLine(character);
        //    }
        //}




        //ASSIGNMENT 1
        //static void Main()
        //{
        //    string[] names = { "John", "Peter", "Jacob", "Harry", "Jackson" };


        //    var result = names.Where(names => names.Contains("o"));

        //    Console.WriteLine("name which contain o :");
        //    foreach (string name in result)
        //        Console.WriteLine(name);
        //}





        //ASSIGNMENT 2
        //static void Main()
        //{
        //    string[] capitals = { "John", "Peter", "Jacob", "Harry", "Jackson" };

        //    var res = capitals.OrderBy(c => c.Length);
        //    var result = capitals.Skip(4);

        //    Console.WriteLine("Name which has max no of character length:");
        //    foreach (string capital in result)
        //          Console.WriteLine(capital);
        //}



        //ASSIGNMENT 3
        //static void Main()
        //{
        //    string[] words = { "believe", "relief", "reciept", "field" };
        //    foreach (string m in words)
        //        Console.WriteLine($"{m} -- {m.Length}");
        //}

        //ASSIGNMENT 4
        //{
        //string[] words = { "blueberry", "blackberry", "abacus" };
        //    foreach (string item in words)
        //        Console.WriteLine(item.Reverse().ToArray());
        //    }







        //private static void Main()
        //{
        //    List<string> words = new List<string> { "basket", "blueberry", "chimpanze",
        //         "abacus", "banana", "apple", "cheese" };

        //    var wordGroups = words.GroupBy(x => x[0]).Select
        //        (y => new { FirstLetter = y.Key, Words = y });

        //    foreach (var item in wordGroups)
        //    {
        //        Console.WriteLine("Words that start with the" +
        //            "letter '{0}':",
        //            item.FirstLetter);
        //        foreach (var w in item.Words)
        //        {
        //            Console.WriteLine(w);
        //        }

        //    }
        //}







        public static void Main()
        {
            List<string> words = new List<string> { "basket", "blueberry", "chimpanze",
                 "abacus", "banana", "apple", "cheese" };

            var wordGroups = words.GroupBy(x => x[0]).Select
                (y => new { FirstLetter = y.Key, Words = y });

            foreach (var item in wordGroups)
            {
                Console.WriteLine("Words that start with the" +
                    "letter '{0}':",
                    item.FirstLetter);

                foreach (var w in item.Words)
                {
                    Console.WriteLine(w);
                }

            }
        }

        
        
    }
}

