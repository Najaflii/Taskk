using System;

namespace P228
{
    public class Program
    {
        static void Main()
        {
            Addition addition = new Addition();
            Division division = new Division();
            Substraction substraction = new Substraction();
            Multiplication multiplication = new Multiplication();

            Console.WriteLine($"Addition : first number = {1} , second number = {10}. Result = {addition.Operate(1, 10)}");
            Console.WriteLine($"Substraction : first number = {20} , second number = {30}. Result = {substraction.Operate(20, 30)}");
            Console.WriteLine($"Multiplication : first number = {2} , second number = {3}. Result = {multiplication.Operate(2, 3)}");
            Console.WriteLine($"Division : first number = {7} , second number = {8}. Result = {division.Operate(7, 8)}");

        }
    } 

}
