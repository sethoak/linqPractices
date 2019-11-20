using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // Find the words in the collection that start with the letter 'L'
            List<string> fruits = new List<string>()
            {
                "Lemon",
                "Apple",
                "Orange",
                "Lime",
                "Watermelon",
                "Loganberry"
            };

            List<string> LFruits = fruits.Where(fruit =>
            {
                bool L = fruit.StartsWith("L");
                return L;
            }).ToList();


            // Which of the following numbers are multiples of 4 or 6
            List<int> numbers = new List<int>() { 15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96 };
            List<int> multiples = numbers.Where(selected =>
            {
                bool isEquation = (selected % 6 == 0 || selected % 4 == 0);
                return isEquation;
            }).ToList();
        }
    }
}
