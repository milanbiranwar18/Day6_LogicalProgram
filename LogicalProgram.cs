﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6LogicalProgram
{
    internal class LogicalProgram
    {
        public static void FibonacciSeries()
        {
                int number, n1 = 0, n2 = 1, n3, i;

                Console.WriteLine("Enter the number of elements");

                number = int.Parse(Console.ReadLine());
                Console.Write(n1 + "  " + n2 + "  ");
                for (i = 2; i < number; i++)
                {
                    n3 = n1 + n2;
                    Console.Write(n3 + "  ");
                    n1 = n2;
                    n2 = n3;
                }
        }

        public static void PerfectNumber()
        {
            int mn, mx, n, i, sum;
            Console.WriteLine("Input the Starting Range of Number");
            mn = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the Ending Range of Number");
            mx = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The Perfect numbers within the given range");

            for (n = mn; n < mn; n++)
            {
                i = 1;
                sum = 0;
                while (i < n)
                {
                    if (n % i == 0)
                        sum = sum + i;
                    i++;
                }
                if (sum == n)
                    Console.Write("{0} , ", n);
            }
        }

        public static void Reversenumber()
        {
            int n, reverse = 0, rem;
            Console.WriteLine("Enter the number : ");
            n = int.Parse(Console.ReadLine());

            while (n != 0)
            {
                rem = n % 10;
                reverse = reverse * 10 + rem;
                n = n / 10;
            }
            Console.WriteLine("Reverse Number :" + reverse);
        }

        public static void PrimeNumber()
        {

            for (int number = 1; number <= 100; number++)
            {
                int count = 0;

                for (int i = 1; i <= number; i++)
                {
                    if (number % i == 0)
                    {
                        count++;
                    }
                }
                if (count == 2)
                {
                    Console.WriteLine(number);

                }

            }
        }




    }
}
