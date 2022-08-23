double[] CreateArrayRndInt(int size, double max,double min)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round((rnd.NextDouble()*(max-min)+min),2);
    }
    return array;
}
void PrintArr(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write(array[i] + " ,");
    }
    Console.Write(array[array.Length - 1]);
    Console.WriteLine("]");
}
double maxminelem(double[] array)
{
    double maximum = array[0];
    double minimum = array[0];
    // double sum = maximum - minimum;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > maximum)
        {
            maximum = array[i];
        }
        if (array[i] < minimum)
        {
            minimum = array[i];
        }
    }
    double sum = maximum - minimum;
    return sum;
}
double [] arr =CreateArrayRndInt(5,1,12);
PrintArr(arr);
double result = maxminelem(arr);
Console.WriteLine($"{Math.Round(result,2)}");