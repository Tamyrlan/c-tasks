﻿// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да
int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random(); 
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max+1);
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
    Console.Write("]");
}
bool FindElemInArray(int [] array,int n )
{
    bool ret = false;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]!= elemF)
        {
            ret = true;
            break;
        } 
    }
    return ret;
}
Console.WriteLine("Enter your number:");
int findI = Convert.ToInt32(Console.Readline());
