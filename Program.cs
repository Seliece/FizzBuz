using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main() {

            // Get the max count and stores it to the variable "count"
            Console.WriteLine("To how high do you want to count?");
            int count = int.Parse(Console.ReadLine());

            // Ask if you want to display empty charachters
            Console.WriteLine("Do you want to see the empty values, \"Y\" or \"N\"");
            bool showEmptyChars = (Console.ReadKey(true).KeyChar == 'Y');

            // define empty currentWord
            string currentWord = "";
            for (int i = 1; i <= count; i++) {

                // Check if it is divisible by 3 or 5 and add that part to the word
                if (i % 3 == 0) {
                    currentWord += "Fizz";
                }
                if (i % 5 == 0) {
                    currentWord += "Buzz";
                }

                // Print the current word
                if (showEmptyChars || currentWord != "") {
                    Console.WriteLine($"{i}: {currentWord}");
                }

                // Resets the current word
                currentWord = "";
            }
        }
    }
}
