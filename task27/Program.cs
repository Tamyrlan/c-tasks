Console.Write("Введите ваше число:");
int summ = 0;
int x = 0;
int number = Convert.ToInt32(Console.ReadLine());
while (number > 0)
{
    x = number % 10;
    number = number / 10;
    summ = summ + x;
}
Console.WriteLine($"Сумма цифр в числе = {summ}");
