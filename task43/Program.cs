// Задача 43: Напишите программу, которая найдёт точку 
//пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)
Console.Write("Enter b1:");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter k1:");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter b2:");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter k2:");
double k2 = Convert.ToDouble(Console.ReadLine());


double x1 = 0;
double y1 = k1 * x1 + b1;

double x2 = 0;
double y2 = k2 * x2 + b2;

double x = 0, y = 0;
x = (b2 - b1) / (k1 - k2);
y = k1 * x + b1;

Console.WriteLine("x={0}", +x);
Console.WriteLine("y={0}", +y);
