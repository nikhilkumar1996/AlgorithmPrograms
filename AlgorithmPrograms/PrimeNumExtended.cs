using System;

namespace AlgorithmPrograms
{
    public class PrimeNumExtended
    {
        int count = 0;
        public void FindPrime(int num)
        {
            for (int i = 1; i < num; i++)
            {
                for (int j = 1; j < num; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                    }
                }
                if (count == 2)
                {
                    Console.WriteLine(i + " ");
                }
                count = 0;
            }
        }
    }
}