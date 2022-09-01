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
int[] FindRowWithLessNum(int[,] matrix)
{
    int[] sumInRow = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumInRow[i] = sumInRow[i] + matrix[i, j];
        }
    }
    return sumInRow;

}
int RowWithMinSUm(int[] sum)
{
    int minIndex = 0;
    for (int i = 0; i < sum.Length; i++)
    {
        if (sum[i] < sum[minIndex]) minIndex = i;
    }
    return minIndex +1;
}

int[,] matr = CreateMatrixRndInt(5, 4, 1, 10);
PrintMatrix(matr);
Console.WriteLine();
int[] result = FindRowWithLessNum(matr);
Console.WriteLine("Sum in each row =>: [" + string.Join(", ", result) + "]");
Console.WriteLine("Row with minimal summ of numbers is " + RowWithMinSUm(FindRowWithLessNum(matr)));