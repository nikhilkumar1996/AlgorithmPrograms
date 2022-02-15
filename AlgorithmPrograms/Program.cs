﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcoome to Algorithm Programs");
            Console.WriteLine("1.Permutation Using Recurrsion" +
                              "\n2.BinarySearch" +
                              "\n3.Insertion Sort" +
                              "\n4.Exit");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Choose Program");
                int choose=Convert.ToInt32(Console.ReadLine());

                switch (choose)
                {
                    case 1:
                        Console.WriteLine("Enter String to find Permutation ");
                        string str = Console.ReadLine();
                        int n = str.Length;
                        Permutation.Permutate(str, 0, n - 1);
                        break;

                    case 2:
                        string txtpath = File.ReadAllText(@"E:\github\AlgorithmPrograms\AlgorithmPrograms\TextFile.txt");
                        List<string> words = new List<string>(txtpath.Split());
                        words.Sort();
                        BinarySearch.BinarySearchWord(words);
                        break;

                    case 3:
                        InsertionSort insertionSort = new InsertionSort();
                        int[] arr = { 10, 2, 14, 3, 1, 5, 9 };
                        insertionSort.Sort(arr);
                        insertionSort.PrintArray(arr);
                        break;

                    case 4:
                        flag = false;
                        break;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;

                }
            }
        }
    }
}
