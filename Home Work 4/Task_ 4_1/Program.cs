using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Task__4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Task 1

            Write("Введите количество строк массива: ");
            int RowsCount = byte.Parse(ReadLine());
            Write("Введите количество столбцов массива: ");
            int ColumnsCount = byte.Parse(ReadLine());

            // создаю массив
            int [,] matrix1 = new int[RowsCount, ColumnsCount];

            Random RandGen= new Random();
            int sum1 = 0;

            // заполняю массив случайными числами от 0 до 100
            // вообще для оптимизации толкаю все в один цикл
            // хотя для наглядности наверное надо было сначала заполнить потом
            // вывести и просуммировать
            WriteLine("Matrix 1:");
            for (int i=0; i<RowsCount; i++)
            {
                for (int j=0; j<ColumnsCount; j++)
                {
                    matrix1[i, j] = RandGen.Next(0, 100);
                    sum1 += matrix1[i, j];
                    Write($"{matrix1[i, j]}, ");
                }
                WriteLine();
            }

            WriteLine($"Сумма всех элементов = {sum1}");
            ReadKey();

            // TAsk 2  Сложение двух матриц
            int[,] matrix2 = new int[RowsCount, ColumnsCount];
            int[,] matrixSum = new int[RowsCount, ColumnsCount];

            WriteLine("\nMatrix 2:");
            // здесь разобью на два цикла, чтоб была видна логика, хотя посоветуйте, может и не надо
            // заполняем вторую матрицу
            for (int i = 0; i < RowsCount; i++)
            {
                for (int j = 0; j < ColumnsCount; j++)
                {
                    matrix2[i, j] = RandGen.Next(0, 100);
                    Write($"{matrix2[i, j]}, ");
                }
                WriteLine();
            }

            WriteLine("\nMatrix 1 + Matrix 2:");

            for (int i = 0; i < RowsCount; i++)
            {
                for (int j = 0; j < ColumnsCount; j++)
                {
                    matrixSum[i, j] = matrix1[i, j] + matrix2[i, j];
                    Write($"{matrixSum[i, j]}, ");
                }
                WriteLine();

            }

            ReadKey();



        }
    }
}
