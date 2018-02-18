﻿using Sort;
using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            var entries = new Int32[] { 8, 4, 5, 7, 1, 9, 6, 3, 2, 8, 4, 5, 7, 1, 9, 6, 3, 2, 8, 4, 5, 7, 1, 9, 6, 3, 2, 8, 4, 5, 7, 1, 9, 6, 3, 2, 8, 4, 5, 7, 1, 9, 6, 3, 2, 8, 4, 5, 7, 1, 9, 6, 3, 2, 8, 4, 5, 7, 1, 9, 6, 3, 2, 8, 4, 5, 7, 1, 9, 6, 3, 2, 8, 4, 5, 7, 1, 9, 6, 3, 2, 8, 4, 5, 7, 1, 9, 6, 3, 2, };
            var sorter = new QuickSort<Int32>();
            sorter.Sort(entries);
            Console.WriteLine(String.Join(" ", entries));
            Console.ReadLine();
        }
    }
}
