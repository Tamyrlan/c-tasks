Console.Write("Введите трехзначное число:");
int number = Convert.ToInt32(Console.ReadLine());
int ShowSecondDigit (int number)
{
    int FirstDigit = number / 100;
    int SecondDigit = number / 10 % 10;
    return SecondDigit;
}
int showSecondDigit = ShowSecondDigit(number);
if (number>100 && number < 1000)
{
    Console.WriteLine($"Второе число трехзначного числа = {showSecondDigit}");
}
else
{
    Console.WriteLine("Вы ввели не трехзначное число!");
}