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
        }
    }
}
