using System;
using System.Collections.Generic;
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
                              "2.Exit");
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
