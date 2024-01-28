/* 
 * Author: Diego Carmona
 * Course: COMP003 Intro Prog Concepts Method C#
 * Purpose:To practice and increase familiarity with the data types and methods of C#
 */

namespace COMP003A.Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console Section
            Console.Title = "COMP-003A-Assignment 2";
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;

            // String Section
            string firstName = Console.ReadLine();
            string middleName = Console.ReadLine();
            string lastName = Console.ReadLine();
            string inputAge = Console.ReadLine();
            int yearBorn = 2023 - Convert.ToInt32(inputAge);
            Console.WriteLine($"Hello, {firstName} {middleName} {lastName}. You were born in {yearBorn}.");
            
            //Math Section
            string num1 = "5";
            string num2  = "6";
            int integer1 = Convert.ToInt32(num1);
            int integer2 = Convert.ToInt32(num2);
            Console.WriteLine($"{integer1} + {integer2} = {integer1 + integer2}");
            Console.WriteLine($"{integer1} - {integer2} = {integer1 - integer2}");
            Console.WriteLine($"{integer1} * {integer2} = {integer1 * integer2}");
            Console.WriteLine($"{integer1} / {integer2} = {integer1 / integer2}");
            Console.WriteLine($"{integer1} % {integer2} = {integer1 % integer2}");

            //Circle Area and Circumference Calculator Section
            double radius = Convert.ToDouble( Console.ReadLine() );
            double area = Math.PI * Math .Pow( radius, 2 );
            double circumference = 2 * Math.PI * radius;
            Console.WriteLine(area);
            Console.WriteLine(circumference);
        }
    }
}
