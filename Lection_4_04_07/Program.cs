using System;

namespace Lection_4_04_07
{
    class Program
    {
        static int WithoutARemainder(int a, int b)
        {
            if(b < a)
            {
                Swap(ref a, ref b);
            }

            int sum = 0;
            for (int i = a; i <= b; i++)
            {
                if (i % 7 == 0)
                {
                    sum += i;
                }
            }

            return sum;
        }

        static int Fibonacci(int n)
        {
            int a = 1;
            int b = 1;

            for (int i = 1; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }

            return a;
        }

        static int Euclid(int a, int b)
        {
            while (a != 0 && b != 0)
            {
                if (a > b)
                {
                    a %= b;
                }
                else
                {
                    b %= a;
                }
            }

            return a + b;
        }

        static int OddNumber(int a)
        {
            int count = 0;
            while (a != 0)
            {
                if (a % 2 != 0)
                {
                    count++;
                }

                a /= 10;
            }

            return count;
        }

        static int ReverseOfNumber(int number)
        {
            int result = 0;
            while (number != 0)
            {
                result *= 10;
                result += number % 10;
                number /= 10;
            }

            return result;
        }

        private static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(ReverseOfNumber(-123456));
            Console.WriteLine(ReverseOfNumber(123456));
            Console.WriteLine(ReverseOfNumber(13579));
            Console.WriteLine(ReverseOfNumber(2468));
        }
    }
}
