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
            Console.WriteLine("Input First Name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Input Middle Name");
            string middleName = Console.ReadLine();
            Console.WriteLine("Input Last Name");
            string lastName = Console.ReadLine();
            Console.WriteLine("Input Age in 2023");
            string inputAge = Console.ReadLine();
            int yearBorn = 2023 - Convert.ToInt32(inputAge);
            Console.WriteLine($"Hello, {firstName} {middleName} {lastName}. You were born in {yearBorn}.");

            //Math Section
            Console.WriteLine("Input Number");
            string num1 = Console.ReadLine();
            Console.WriteLine("Input Secondary Number");
            string num2 = Console.ReadLine();
            int integer1 = Convert.ToInt32(num1);
            int integer2 = Convert.ToInt32(num2);
            Console.WriteLine($"{integer1} + {integer2} = {integer1 + integer2}");
            Console.WriteLine($"{integer1} - {integer2} = {integer1 - integer2}");
            Console.WriteLine($"{integer1} * {integer2} = {integer1 * integer2}");
            Console.WriteLine($"{integer1} / {integer2} = {integer1 / integer2}");
            Console.WriteLine($"{integer1} % {integer2} = {integer1 % integer2}");

            //Circle Area and Circumference Calculator Section
            Console.WriteLine("Input radius of circle");
            double radius = Convert.ToDouble( Console.ReadLine() );
            double area = Math.PI * Math .Pow( radius, 2 );
            double circumference = 2 * Math.PI * radius;
            Console.WriteLine($"Your area of the circle is {area}.");
            Console.WriteLine($"Your circle's circumference is {circumference}.");
        }
    }
}
