using System;
using System.Linq;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your a comma separated list of numbers.");
            var input = Console.ReadLine();

            var numbers = input.Split(',');

            foreach (var number in numbers)
            {
                int.Parse(number);
                Console.WriteLine(number);
            }
            //Console.WriteLine("Please choose an operator from following list:  squareRoot, add, subtract, multiply, average, divide");
            //var operation = Console.ReadLine();
            //var squareRoot = double Math.Sqrt();
            //var add = 
            //if (operation == squareRoot)

            //var SquareRoot = operation(Math.Sqrt(number));
          
            Console.WriteLine("Choose an option from the following list:");
            Console.WriteLine("\ta - Add");
            Console.WriteLine("\ts - Subtract");
            Console.WriteLine("\tm - Multiply");
            Console.WriteLine("\td - Divide");
            Console.WriteLine("\tq - SquareRoot");
            Console.WriteLine("\tv - Average");
            Console.Write("Your option? ");

            // Use a switch statement to do the math.
            var answer = 0;

            switch (Console.ReadLine())
            {
                case "a":
                    foreach (var number in numbers)
                    {
                        answer += int.Parse(number);
                    }
                    Console.WriteLine($"Your result: {answer}");
                    break;
                case "s":
                    foreach (var number in numbers)
                    {
                        answer -= int.Parse(number);
                    }
                    Console.WriteLine($"Your result: {answer}");
                    break;
                case "m":
                    foreach (var number in numbers)
                    {
                        answer *= int.Parse(number);
                    }
                    Console.WriteLine($"Your result: {answer}");
                    break;
                case "d":
                    foreach (var number in numbers)
                    {
                        answer /= int.Parse(number);
                    }
                    Console.WriteLine($"Your result: {answer} ");
                    break;
                case "q":
                    var squaredResult = "";
                    foreach (var number in numbers)
                    {
                        var numbersToSquare = int.Parse(number);
                        var squaredNumber = numbersToSquare * numbersToSquare;
                        squaredResult += $"{squaredNumber},";
                    }
                    squaredResult = squaredResult.Remove(squaredResult.Length - 1);
                    Console.WriteLine($"Your result: {squaredResult}");
                    break;
               case "v":
                    var sum = 0;
                   foreach (var number in numbers)
                  {
                      sum += int.Parse(number);
                   }
                    var averageResult = Convert.ToDecimal(sum) / Convert.ToDecimal(numbers.Length);
                 Console.WriteLine($"Your result: {averageResult}");
                  break;
            }
            // Wait for the user to respond before closing.
            Console.Write("Press any key to close the Calculator console app...");
            Console.ReadKey();
        }
    }
}


    



