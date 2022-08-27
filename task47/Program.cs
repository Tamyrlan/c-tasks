double[,] CreateMatrixRndInt(int row, int col, int min, int max)
{
    double[,] matrix = new double[row, col];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) // row
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // col
        {
            matrix[i, j] = Math.Round(rnd.NextDouble() * (max - min) + min, 2);
        }

    }
    return matrix;
}
void PrintMatrix(double[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}," + " ");
            else Console.Write($"{matrix[i, j],4}" + " ");
        }
        Console.WriteLine("]");

    }
}
double[,] matr = CreateMatrixRndInt(4, 3, -10, 10);
PrintMatrix(matr);