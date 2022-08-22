// Задача 42: 
//Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10
// 13 -> 1101

Console.Write("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
int ChangeToBin(int a)
{
    int result = 0;
    int mult = 1;
    // int b = a%2;
    // int c = a/2
    while (a > 0)
    {
        result += a % 2 * mult;
        a /= 2;
        mult *= 10;
    }
    return result;
}
int res = ChangeToBin(num);
Console.WriteLine(res);