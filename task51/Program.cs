// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.
// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.

// Задача 48: Задайте двумерный массив размера m на n,
// каждый элемент в массиве находится по формуле: Amn = m+n.
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

int[,] CreateMatrixRndInt(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) // row
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // col
        {
            matrix[i,j] = rnd.Next(min, max + 1);
        }
        
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i,j], 4},");
            else Console.Write($"{matrix[i,j], 4}");
        }
        Console.WriteLine("]");

    }
}
int[,] SumElem(int[,] matrix)
{
    int summ = 0;
        for (int i = 0; i < matrix.GetLength(0); i++) // row
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // col
        {
            if (i==j) summ+=matrix[i,j];
        }
        
    }
    return summ;
}

int[,] SumeElem1(int[,] matrix)
{
    int summ =0;
    int size = matrix.GetLength(0);
    if (matrix.GetLength(0)>matrix.GetLength(1)) size = matrix.GetLength(1);
    for (int i = 0; i < size; i++)
    {
        int j =i;
        summ+=matrix[i,j];
    }
    return summ;
}
int[,] matr = CreateMatrixRndInt(3,4,0,10);
PrintMatrix(matr);
Console.WriteLine();
//int[,] result = SumElem(matr);
int[,] result = SumeElem1(matr);
Console.WriteLine(result);