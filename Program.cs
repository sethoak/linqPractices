﻿using System;
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

            // Order these student names alphabetically, in descending order (Z to A)
            List<string> names = new List<string>()
                {"Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
    "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
    "Theodora", "William", "Svetlana", "Charisse", "Yolanda",
    "Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
    "Francisco", "Tre"};

            List<string> descendedOrdered = names.OrderByDescending(name => name).ToList();

            // Build a collection of these numbers sorted in ascending order
            List<int> numbersEx = new List<int>()
                {
                    15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
                };
            List<int> ascendingOrder = numbers.OrderBy(number => number).ToList();


            // Output how many numbers are in this list
            List<int> numbers2 = new List<int>()
                {
                    15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
                };
            // List<int> numberList = numbers.Count(number => number).ToList();
            int count = numbers2.Count();

            // How much money have we made?
            List<double> purchases = new List<double>()
                {
                    2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
                };
            double sum = purchases.Sum();

            // What is our most expensive product?
            List<double> prices = new List<double>()
                {
                    879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
                };
            double maxPrice = prices.Max();

            /*
    Store each number in the following List until a perfect square
    is detected.

    Ref: https://msdn.microsoft.com/en-us/library/system.math.sqrt(v=vs.110).aspx
*/
            List<int> wheresSquaredo = new List<int>()
                {
                    66, 12, 8, 27, 82, 34, 7, 50, 19, 46, 81, 23, 30, 4, 68, 14
                };
            var result = wheresSquaredo.TakeWhile(num =>
            {
                bool isSquared = Math.Sqrt(num) % 1 == 0;
                return !isSquared;
            }).ToList();

            foreach (int item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
