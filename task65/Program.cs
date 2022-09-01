// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

Console.Write("Введите первое число:");
int firstnum = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число:");
int secondnum = Convert.ToInt32(Console.ReadLine());
void NaturalNumberBetween(int num1, int num2)
{
    if (num1 == num2)
    {
        Console.Write($"{num2} ");
        return;
    }
    NaturalNumberBetween(num1, num2 - 1);
    Console.Write($"{num2} ");
}
void NaturalNumberBetween2(int number1,int number2)
{
    if (number1 == number2)
    {
        Console.Write($"{number1} ");
        return;
    }
    NaturalNumberBetween(number2, number1-1);
    Console.Write($"{number1} ");
    
}
if (firstnum > secondnum)
{
    NaturalNumberBetween2(firstnum,secondnum);
}
else NaturalNumberBetween(firstnum, secondnum);
