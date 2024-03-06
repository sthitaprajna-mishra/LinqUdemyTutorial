using System;
using System.Collections.Generic;
using System.Diagnostics;
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

            // Section 6

            //var pets = new[] {
            //    new Pet(1, "Hannibal", PetType.Fish, 1.1f),
            //    new Pet(2, "Anthony", PetType.Cat, 2f),
            //    new Pet(3, "Ed", PetType.Cat, 0.7f),
            //    new Pet(4, "Taiga", PetType.Dog, 35f),
            //    new Pet(5, "Rex", PetType.Dog, 40f),
            //    new Pet(6, "Lucky", PetType.Dog, 5f),
            //    new Pet(7, "Storm", PetType.Cat, 0.9f),
            //    new Pet(8, "Nyan", PetType.Cat, 2.2f),
            //};

            //bool isHannibalPresent = pets.Contains(new Pet(1, "Hannibal", PetType.Fish, 1.1f));
            //Console.WriteLine(isHannibalPresent);

            //bool isHannibalPresentUsingComparer = pets.Contains(new Pet(1, "Hannibal", PetType.Fish, 1.1f), new PetComparerById());
            //Console.WriteLine(isHannibalPresentUsingComparer);


            //Console.ReadKey();
        }

        public static int CountFriendsOf(Friend friend, IEnumerable<Person> people)
        {
            int counter = 0;

            foreach (Person person in people)
            {
                if (people.Friends.Contains(friend, new FriendComparer()))
                {
                    counter++;
                }
            }

            return counter;
        }

        public class Person
        {
            public string Name { get; }
            public IEnumerable<Friend> Friends { get; }

            public Person(string name, IEnumerable<Friend> friends)
            {
                Name = name;
                Friends = friends;
            }
        }

        public class Friend
        {
            public string Name { get; }
        }

        public class FriendComparer : IEqualityComparer<Friend>
        {
            public bool Equals(Friend X, Friend Y)
            {
                return X.Name == Y.Name;
            }

            public int GetHashCode(Friend X)
            {
                return X.Name.Length;
            }
        }

        #region Section 6


        public enum PetType
        {
            Cat,
            Dog,
            Fish
        }

        public class PetComparerById : IEqualityComparer<Pet>
        {
            bool IEqualityComparer<Pet>.Equals(Pet x, Pet y)
            {
                return x.Id == y.Id;
            }

            int IEqualityComparer<Pet>.GetHashCode(Pet obj)
            {
                return obj.Id;
            }
        }

        public class Pet
        {
            public int Id { get; }
            public string Name { get; }
            public PetType PetType { get; }
            public float Weight { get; }

            public Pet(int id, string name, PetType petType, float weight)
            {
                Id = id;
                Name = name;
                PetType = petType;
                Weight = weight;
            }

            public override string ToString()
            {
                return $"Id: {Id}, Name: {Name}, Type: {PetType}, Weight: {Weight}";
            }
        }

        #endregion



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
