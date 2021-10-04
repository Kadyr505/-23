using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите размер матрицы: ");
            int size = Int32.Parse(Console.ReadLine());

            int[,] arr = new int[size, size];
            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                    arr[i, j] = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < size; i++)
            {
                int sum = 0;
                if (arr[i, i] % 2 != 0)
                    continue;

                for (int j = 0; j < size; j++)
                    sum += arr[i, j];

                Console.WriteLine("Сумма по строке [" + (i + 1) + "] = " + sum);
            }
        }
    }
}