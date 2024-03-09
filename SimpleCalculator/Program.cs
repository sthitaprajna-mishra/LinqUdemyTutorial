namespace SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isParsingSuccessful = int.TryParse("123a", out int number);
            if(isParsingSuccessful)
            {
                Console.WriteLine(number);
            } else
            {
                Console.WriteLine("Unsuccessful! :(");
            }

            //Console.WriteLine("Hello!");
            //Console.WriteLine("Input the first number: ");
            //int num1 = int.Parse(Console.ReadLine()); // don't handle invalid input
            //Console.WriteLine("Input the second number: ");
            //int num2 = int.Parse(Console.ReadLine()); // don't handle invalid input
            //Console.WriteLine("What do you want to do with those numbers?");
            //Console.WriteLine("[A]dd");
            //Console.WriteLine("[S]ubtract");
            //Console.WriteLine("[M]ultiply");
            //string userChoice = Console.ReadLine();
            //switch(userChoice.ToUpper())
            //{
            //    case "A":
            //        Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
            //        break;
            //    case "S":
            //        Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
            //        break;
            //    case "M":
            //        Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
            //        break;
            //}
            //Console.WriteLine("Press any key to close");
            //Console.ReadKey();
        }
    }
}