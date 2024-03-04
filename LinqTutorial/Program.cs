using System;
using System.Collections.Generic;
using System.Linq;
using LinqTutorial.MethodSyntax;

namespace LinqTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            //METHOD SYNTAX

            //Any.Run();
            //All.Run();
            //Count.Run();
            //Contains.Run();
            //OrderBy.Run();
            //MinMax.Run();
            //Average.Run();
            //Sum.Run();
            //ElementAt.Run();
            //FirstLast.Run();
            //SingleElement.Run();
            //Where.Run();
            //Take.Run();
            //Skip.Run();
            //OfType.Run();
            //Distinct.Run();
            //PrependAppend.Run();
            //ConcatUnion.Run();
            //TypeSwitching.Run();           
            //Select.Run();
            //SelectMany.Run();
            //GeneratingNewCollection.Run();
            //GroupBy.Run();
            //IntersectExcept.Run();
            //Joins.Run();
            //Aggregate.Run();
            //Zip.Run();

            //QUERY SYNTAX

            //OrderBy.QuerySyntax.Run();
            //Where.QuerySyntax.Run();
            //Select.QuerySyntax.Run();
            //SelectMany.QuerySyntax.Run();
            //GroupBy.QuerySyntax.Run();
            //Joins.QuerySyntax.Run();

            //OTHERS
            //DotNet6Improvements.Run();

            // Chapter6

            //var numbers = new[]{ 1, 4, 3, 99, 256, 2 };

            //bool isAnyLargerThan100 = IsAny(numbers, number => number > 100); //IsAnyLargerThan100(numbers);
            //Console.WriteLine($"Is any > 100?: {isAnyLargerThan100}");

            //bool IsAnyEvenPresent = IsAny(numbers, number => number%2 == 0); //IsAnyEven(numbers);
            //Console.WriteLine($"Is any even?: {IsAnyEvenPresent}");

            // Chapter7

            //var numbers = new List<int> { 5, 3, 7, 1, 2, 4 };
            //var numbersWith10 = numbers.Append(10);

            //Console.WriteLine("Numbers: " + string.Join(",", numbers));
            //Console.WriteLine("Numbers with 10: " + string.Join(",", numbersWith10));

            //var oddNumbers = numbersWith10.Where(number => number % 2 != 0).OrderBy(number => number);
            //Console.WriteLine("Numbers: " + string.Join(",", oddNumbers));




            Console.ReadKey();
        }



        #region Chapter6

        private static bool IsAny(int[] numbers, Func<int, bool> predicate)
        {
            foreach (int number in numbers)
            {
                if (predicate(number)) return true;
            }
            return false;
        }

        private static bool IsLargerThan100(int num)
        {
            return num > 100;
        }

        private static bool IsEven(int num)
        {
            return num%2 == 0;
        }


        private static bool IsAnyLargerThan100(int[] numbers)
        {
            foreach(int number in numbers)
            {
                if (number > 100) return true;
            }
            return false;
        }

        private static bool IsAnyEven(int[] numbers)
        {
            foreach (int number in numbers)
            {
                if (number%2 == 0) return true;
            }
            return false;
        }

        #endregion
    }
}
