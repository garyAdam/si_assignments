using System;

namespace SortString
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = "Testing the string tester testing test";
            string[] testArray = test.Split(" ");
            Array.Sort(testArray);

            test = string.Join(" ", testArray);
            Console.WriteLine(test);
        }
    }
}
