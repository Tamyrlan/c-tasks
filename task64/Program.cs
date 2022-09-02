Console.Write("Введите целое положительное число:");
int num = Convert.ToInt32(Console.ReadLine());
void NaturalNumber(int number)
{
    if (number == 0) return;
    Console.Write($"{number},");
    NaturalNumber(number -1);
}
Console.Write("Натуральные числа в промежутке =>[");
NaturalNumber(num);
Console.Write("]");