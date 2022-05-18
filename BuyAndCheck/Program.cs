using System;

namespace Matrices
{

    class Prog
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть непарне ціле число - розмірність матриці");
            int size = Convert.ToInt32(Console.ReadLine());
            int[,] matr = new int[size, size];
            if (size % 2 != 0) // розмірність непарна
            {
                int mid = size / 2; // цілочисельне ділення - з округленням донизу
                // 1 - лівий верхній куток
                for (int i = 0; i < mid; ++i)
                {
                    for (int j = 0; j < mid - i; j++)
                    {
                        matr[i, j] = 1;
                    }
                }
                // 2 - правий верхній куток
                for (int i = 0; i < mid; ++i)
                {
                    for (int j = size - 1; j > i + mid; --j)
                    {
                        matr[i, j] = 2;
                    }
                }
                // 3 - лівий нижній куток
                for (int i = size - mid; i < size; ++i)
                {
                    for (int j = 0; j <= i - mid - 1; ++j)
                    {
                        matr[i, j] = 3;
                    }
                }
                // 4 - правий нижній куток
                for (int i = size - mid; i < size; ++i)
                {
                    for (int j = size - i + mid; j < size; ++j)
                    {
                        matr[i, j] = 4;
                    }
                }

            }
            else
            {
                Console.WriteLine("Помилка: треба було ввести непарну розмірність");
                return;
            }
            for (int i = 0; i < size; ++i)
            {
                for (int j = 0; j < size; ++j)
                {
                    Console.Write(matr[i, j] + " ");
                }
                Console.WriteLine();
            }


        }
    }
}