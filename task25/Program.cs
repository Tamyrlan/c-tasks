Console.Write("Введите первое число:");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число:");
int b = Convert.ToInt32(Console.ReadLine());
int x = a;
for (int i=1; i < b; i++)
{
    x = x*a;
}

Console.WriteLine($"Первое число в степени второго числа =>{x}");