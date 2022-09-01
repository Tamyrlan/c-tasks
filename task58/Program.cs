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
int[,] MultMatrix(int[,] matrix1, int[,] matrix2)
{
    int row = matrix1.GetLength(0);
    int col = matrix1.GetLength(1);
    int[,] matrix3 = new int[row, col];
    if (matrix1.GetLength(0) == matrix2.GetLength(0) &&
        matrix1.GetLength(1) == matrix2.GetLength(1))
    {
        for (int i = 0; i < matrix3.GetLength(0); i++)
        {
            for (int j = 0; j < matrix3.GetLength(1); j++)
            {
                int sum = 0;
                for (int k = 0; k < matrix1.GetLength(1); k++)
                {
                    sum+= matrix1[i, k] * matrix2[k, j];
                }
                matrix3[i,j]=sum;

                // matrix3[i, j] = (matrix1[i, j] * matrix2[j, i]) +
                // (matrix1[i, j + 1] * matrix2[j, i]);
            }
        }

    }
    return matrix3;
}
int[,] matr1 = CreateMatrixRndInt(2, 2, 1, 10);
int[,] matr2 = CreateMatrixRndInt(2, 2, 1, 10);
int[,] matr3 = MultMatrix(matr1, matr2);
PrintMatrix(matr1);
Console.WriteLine();
PrintMatrix(matr2);
Console.WriteLine();
PrintMatrix(matr3);