using System;
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
                              "\n4.BubbleSort" +
                              "\n5.MergeSort" +
                              "\n6.Anagram" +
                              "\n7.PrimeNumbers in Range" +
                              "\n8.Exit");
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
                        int[] arr1 = { 10, 2, 14, 3, 1, 5, 9 };
                        BubbleSort.BubbleSortInArray(arr1);
                        BubbleSort.PrintArray(arr1);
                        break;

                    case 5:
                        int[] arr2 = { 32, 12, 9, 65, 24, 5 };
                        MergeSort.Sort(arr2, 0, arr2.Length - 1);
                        MergeSort.PrintArray(arr2);
                        break;

                    case 6:
                        Anagram.FindAnagram();
                        break;

                    case 7:
                        Console.WriteLine("The prime numbers are : ");
                        PrimeNos primeNum = new PrimeNos();
                        primeNum.FindPrime();
                        break;


                    case 8:
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
