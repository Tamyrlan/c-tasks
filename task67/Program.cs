// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9
Console.Write("Enter Natural Number:");
int num = Convert.ToInt32(Console.ReadLine());
int SummOfNum(int number)
{
    int sum = number % 10;
    if (number > 0) sum += SummOfNum(number / 10);
    return sum;
}
int res = SummOfNum(num);
Console.WriteLine(res);