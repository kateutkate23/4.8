using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // задание 1
            Random random = new Random();

            Write("Введите количество строк: ");
            int rows = int.Parse(ReadLine());
            Write("Введите количество столбцов: ");
            int columns = int.Parse(ReadLine());

            int[,] array = new int[rows, columns];
            int sum = 0;
            
            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < columns; j++)
                {
                    // поставила от -10 до 10 для удобства проверки
                    array[i, j] = random.Next(-10, 10); 
                    sum += array[i, j];
                }
            }

            WriteLine("Полученная случайная матрица: ");
            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < columns; j++)
                {
                    Write($"{array[i,j]} ");
                }
                WriteLine();
            }
            WriteLine($"Сумма элементов матрицы: {sum}");
            ReadKey();

            // задание 2
            int[,] a = new int[rows, columns];
            int[,] b = new int[rows, columns];
            int[,] result = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    // поставила от -10 до 10 для удобства проверки
                    a[i, j] = random.Next(-10, 10);
                    b[i, j] = random.Next(-10, 10);
                    result[i, j] = a[i, j] + b[i, j];
                }
            }

            WriteLine("Полученная матрица A: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Write($"{a[i, j]} ");
                }
                WriteLine();
            }

            WriteLine("Полученная матрица B: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Write($"{b[i, j]} ");
                }
                WriteLine();
            }

            WriteLine("Полученная матрица A + B: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Write($"{result[i, j]} ");
                }
                WriteLine();
            }
            ReadKey();
        }
    }
}
