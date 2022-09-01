﻿// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
int[,,] CreateMatrixRndInt(int row, int col, int depth, int min, int max)
{
    int[,,] matrix = new int[row, col, depth];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) // row
    {
        for (int j = 0; j < matrix.GetLength(1); j++) //col
        {
            for (int k = 0; k < matrix.GetLength(2); k++) // depth
            {
                    matrix[i, j, k] = min+1;
                    min++;

            }
        }

    }
    return matrix;
}
void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write("[");
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                if (k < matrix.GetLength(2) - 1) Console.Write($"{matrix[i, j, k],4}," + $"{(i, j, k)}");
                else Console.Write($"{matrix[i, j, k],4}" + $"{(i, j, k)}");
            }
            Console.WriteLine("]");

        }
    }
}

int[,,] matr = CreateMatrixRndInt(2, 2, 2, 10, 20);
PrintMatrix(matr);