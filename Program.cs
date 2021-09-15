using System;

namespace CSharp_Calculator
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter the first number: ");
            int first_number = Int32.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int second_number = Int32.Parse(Console.ReadLine());
            Console.Write("Enter the operation: ");
            string operation = Console.ReadLine();
            if (operation == "+"){
                Console.WriteLine(first_number + second_number);
            }
            else if (operation == "-"){
                Console.WriteLine(first_number - second_number);
            }
            else if (operation == "/"){
                Console.WriteLine(first_number / second_number);
            }
            else if (operation == "*" || operation == "x"){
                Console.WriteLine(first_number * second_number);
            }
            else{
                Console.WriteLine("Operation or Number invalid, trynna again.");
            }
        }
    }
}
