int n;
Console.Write("Введите пятизначное число: ");
n = Convert.ToInt32(Console.ReadLine());
if (n <= 9999 || n >= 1000000)
{
    Console.WriteLine("Неверное число, пожалуиста введите пятизначное число!");
}
if (n % 10 == n / 10000 && (n % 100) / 10 == (n / 1000) % 10)
{
    Console.WriteLine("Да, это палиндром!");
}
else Console.WriteLine("Нет, это не палиндром");