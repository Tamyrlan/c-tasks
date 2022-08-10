Console.Write("Введите число N:");
int num = Convert.ToInt32(Console.ReadLine());
int i = 2;
while (i <= num)
{
    Console.WriteLine($"Четные числа = {i}");
    i+=2;
}
