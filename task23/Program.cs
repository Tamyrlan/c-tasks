// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введито число:");
int n, i = 1;
n = Convert.ToInt32(Console.ReadLine());
while (i <= n)
{
    Console.WriteLine(i * i * i);
    i++;
}