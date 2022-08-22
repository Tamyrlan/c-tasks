// Задача 40: Напишите программу, 
//1.которая принимает на вход три
//2. числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// (подсказка)Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон

Console.Write("Введите первое число:");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число:");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число:");
int c = Convert.ToInt32(Console.ReadLine());
bool CheckTriangle(int a1, int b1, int c1)
{
    // if (a1 + b1 > c1 && b1 + c1 > a1 && c1 + a1 > b1)
    // {
    //     return true;
    // }
    // return false;
    return a1 + b1 > c1 && b1 + c1 > a1 && c1 + a1 > b1;
}
bool result = CheckTriangle (a,b,c);
// if (result) Console.Write("Три числа являются треугольником");
// else Console.Write("Три числа не являются треугольником");
Console.Write(result? "Три числа являются треугольником":"Три числа не являются треугольником");