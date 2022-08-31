int[,] CreateMatrixRndInt(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) // row
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // col
        {
            matrix[i, j] = rnd.Next(min, max + 1);
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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4},");
            else Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine("]");

    }
}
void SortRowInMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1) - j - 1; k++)
            {
                if (matrix[i, k] < matrix[i, k + 1])
                {
                    int elem = matrix[i, k+1];
                    matrix[i, k+1] = matrix[i, k];
                    matrix[i, k] = elem;

                }
            }

        }
    }
}
int[,] matr = CreateMatrixRndInt(4, 5, 1, 10);
PrintMatrix(matr);
SortRowInMatrix(matr);
Console.WriteLine();
PrintMatrix(matr);