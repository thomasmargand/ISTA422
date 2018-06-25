using System;
using System.Text;
using System.Security.Cryptography;
using System.IO;
using System.Threading;

namespace Exercise14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a password to be cracked: ");
            string input = Console.ReadLine();
            string output = "";

            for(int i = 0; i < input.Length - 1; i++)
            {
                int j = (int)input[i];
                char k = (char)BinarySearch(j);
                output = output + k;
            }

            Console.WriteLine($"{output}");

            int BinarySearch(int n)
            {
                int low = 32;
                int mid = 0;
                int high = 128;

                while (low <= high)
                {
                    mid = (low + high) / 2;
                    if (mid < n)
                    {
                        low = mid + 1;
                    }
                    if (mid > n)
                    {
                        high = mid - 1;
                    }
                    if (n > 128 || n < 0)
                    {
                        return 0;
                    }
                }
                return mid;
            }
        }
    }
}
    

