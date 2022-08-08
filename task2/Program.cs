Console.Write("Введите первое число:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число:");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2)
{
    Console.Write($"Число {number1} больше числа {number2}");
} 
else{
    Console.Write($"Число {number1} меньше числа {number2}");
}