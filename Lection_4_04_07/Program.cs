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
            OddNumber(number);
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
            int shift = 3;
            int size = 10;
            Random random = new Random();
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(1, 100);
            }

            for (int i = 0; i < size; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();

            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            Console.WriteLine((float)sum / array.Length);

        }

        private static void TaskToComplete(int shift, int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int rightIndex = (shift + i) % array.Length;
                Console.WriteLine($"{i}=>{rightIndex}");
                Swap(ref array[i], ref array[rightIndex]);
                PrintArray(array);
            }
        }

        private static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();
        }

        private static void Sort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        Swap(ref array[i], ref array[j]);
                    }
                }
            }
        }

        private static int[] RemoveAllNegativeNumbers(int[] array)
        {
            int newCount = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    newCount++;
                }
            }

            int[] newArray = new int[newCount];
            for (int i = 0, j = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    newArray[j++] = array[i];
                }
            }

            return newArray;
        }

        private static int SumNumbersBetweenMinAndMax(int[] array)
        {
            int minI = 0;
            int maxI = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < array[minI])
                {
                    minI = i;
                }

                if (array[i] > array[maxI])
                {
                    maxI = i;
                }
            }

            if (minI > maxI)
            {
                Swap(ref minI, ref maxI);
            }

            int sum = 0;
            for (int i = minI + 1; i < maxI; i++)
            {
                sum += array[i];
            }

            return sum;
        }

        private static int GetPositiveNumbersCount(int[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    ++count;
                }
            }

            return count;
        }

        private static int GetMostCommonNumberIndex(int[] array)
        {
            int maxCount = 0;
            int maxCountIndex = 0;
            for (int j = 0; j < array.Length; j++)
            {
                int currentCount = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == array[j])
                    {
                        ++currentCount;
                    }
                }

                if (currentCount > maxCount)
                {
                    maxCount = currentCount;
                    maxCountIndex = j;
                }
            }

            return maxCountIndex;
        }

        private static void MoveZerosToBeginning(int[] array)
        {
            int position = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] == 0)
                {
                    Swap(ref array[i], ref array[position++]);
                }
            }
        }
    }
}
