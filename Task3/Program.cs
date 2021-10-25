using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            var cone = new Cone.Cone(5, 4);
            var result1 = cone.CountSquareOfTheRound(3.14);
            var result2 = cone.CountSquareOfTheCone(result1, 4);
            Console.WriteLine($"Square of the round is {result1}");
            Console.WriteLine($"Square of the cone is {result2}");

        }
    }
}
