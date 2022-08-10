Console.Write("Введите число:");
long num = Convert.ToInt64(Console.ReadLine());
if (num %2 ==0)
{
    Console.Write($"Число {num} четное");
}
else
{
    Console.Write($"Число {num} не четное");
}