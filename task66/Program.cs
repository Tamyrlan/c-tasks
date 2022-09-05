// Задача 66: Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите первое число:");
int firstnum = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число:");
int secondnum = Convert.ToInt32(Console.ReadLine());
int SumOFNaturalNumberBetween(int num1, int num2)
{
    if (num1 == num2) return num1;
    else return num2 + SumOFNaturalNumberBetween(num1, num2 - 1);
}

void NaturalNumberBetween(int number1, int number2)
{
    if (number1 == number2)
    {
        Console.Write($"{number1}, ");
        return;
    }
    if (number1 > number2)
    {
        Console.Write($"{number1}, ");
        NaturalNumberBetween(number1 - 1, number2);
    }
    else
    {
        NaturalNumberBetween(number1, number2 - 1);
        Console.Write($"{number2}, ");
    }
}
NaturalNumberBetween(firstnum, secondnum);
Console.WriteLine();

int res = SumOFNaturalNumberBetween(firstnum, secondnum);
Console.WriteLine($"Сумма натуральных чисел = {res}");
