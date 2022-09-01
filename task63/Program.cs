Console.WriteLine("Введите целое положительное число:");
int num = Convert.ToInt32(Console.ReadLine());
void NaturalNumber(int number)
{
    if (number == 0) return;
    NaturalNumber(number -1);
    Console.Write($"{number} ");
}
NaturalNumber(num);