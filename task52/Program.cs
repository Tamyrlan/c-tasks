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
void PrintArr(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i],4}"+ ", ");
    }
    Console.Write(array[array.Length - 1]);
    Console.WriteLine("]");
}
int[,] matr = CreateMatrixRndInt(4, 4, 1, 10);
PrintMatrix(matr);

Console.WriteLine();

double [] FindAvarageNumInArray(int[,] matrix)
{
    int [] summInCol = new int [matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            summInCol[i] = summInCol[i] + matrix[j, i];
        }
    }
    double[] avg = new double[matrix.GetLength(1)];
    for (int k = 0; k < matrix.GetLength(1); k++)
    {
        avg[k] = Convert.ToDouble(summInCol[k]) / matrix.GetLength(0);
    }
    return avg;
}
double[] result = FindAvarageNumInArray(matr);
Console.WriteLine("Avarage number in each column is equal to:");
PrintArr(result);