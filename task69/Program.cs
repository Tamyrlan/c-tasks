// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.Write("Enter first number:");
int firstNum  = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second number:");
int secondNum  = Convert.ToInt32(Console.ReadLine());
int mult(int num1,int num2)
{
    int sum = num1;
    if (num2==0) return 1;
    else sum*=mult(num1,num2-1);
    return sum;
}
int result = mult(firstNum,secondNum);
Console.WriteLine(result);