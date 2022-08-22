// Задача 36: Задайте одномерный массив, 
//заполненный случайными числами. Найдите сумму элементов, 
//стоящих на нечётных позициях (индексах).
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}
void PrintArr(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write(array[i] + ",");
    }
    Console.Write(array[array.Length - 1]);
    Console.WriteLine("]");
}
int multelem(int[] array)
{
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if(i%2!=0)
    {
         count += array[i];       
    }
}
return count;
}
int [] arr = CreateArrayRndInt(8,1,10);
PrintArr(arr);
int coun = multelem(arr);
Console.WriteLine($"{coun}");