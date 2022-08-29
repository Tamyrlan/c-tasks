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
int[,] matr = CreateMatrixRndInt(4, 4, -10, 10);
PrintMatrix(matr);

Console.Write("Enter row:");
int rownum = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter column:");
int colnum = Convert.ToInt32(Console.ReadLine());

void FindElemInArray(int[,] matrix ,int rownum, int colnum)
{
 if(rownum < matrix.GetLength(0) && colnum < matrix.GetLength(1))
 {
    Console.Write($"Your element is => {matrix[rownum,colnum]}");
 }
 else Console.Write("There is no such element in matrix :(");
}
FindElemInArray(matr,rownum,colnum);