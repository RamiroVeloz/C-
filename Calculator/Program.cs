using System;
using System.IO;

//CREAR UN OBJETO <T> PARA CONTROLAR LOS VALORES
namespace Calculator;
class Program {

    static double ReadDouble (string message) {
        double res;
        while (true) {
            Console.WriteLine(message);
            if (double.TryParse(Console.ReadLine(), out res)){
                return res;
            } else {
                Console.WriteLine("Invalid input. Next time enter a valid number.");
            }
        }
    }
    static void Main(string [] args){


        Operator op = new Operator ();
        Console.WriteLine("Welcome to a console calculator.");
        Console.WriteLine("This are the available options:");
        Console.WriteLine ($"1 to add two numbers\n2 to substract 2 numbers\n3 to multiply 2 numbers\n4 to divide two numbers\n5 to get the module from the divition of two numbers\n Any number to exit");
        Console.WriteLine ("For decimal numbers, use . to separate. Ex: 3.4");
        Console.Write("Type your choice: "); string choice = Console.ReadLine();
        double valueA = ReadDouble("Type the first value: ");
        double valueB = ReadDouble("Type the second value: ");

            switch (choice) {
                case "1":
                    Console.WriteLine ($"Result: {op.AddValues(valueA, valueB)}");
                    break;
                case "2":
                    Console.WriteLine ($"Result: {op.SubValues(valueA, valueB)}");
                    break;
                case "3":
                    Console.WriteLine ($"Result: {op.MulValues(valueA, valueB)}");
                    break;
                case "4":
                    Console.WriteLine ($"Result: {op.DivValues(valueA, valueB)}");
                    break;
                case "5":
                    Console.WriteLine ($"Result: {op.ModValues(valueA, valueB)}");
                    break;
                default:
                    Console.WriteLine ($"Bye :D");
                    break;
        }
    }
} 