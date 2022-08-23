
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3
Console.Write("Введите сколько чисел вы хотите указать:");
int num = Convert.ToInt32(Console.ReadLine());
int [] arrayNum = new int [num];
for (int i = 0; i < num; i++)
{
    Console.Write("Введите"+ " " + (i+1) + " "+"число:");
    arrayNum[i] = Convert.ToInt32(Console.ReadLine());
}
Console.Write("[" + string.Join(", ", arrayNum) + "]");
Console.WriteLine();
int countNum(int[] arrayNum)
{
    int count = 0;
    for (int i = 0; i < arrayNum.Length; i++)
    {
        if(arrayNum[i]>0)
        {
            count++;
        }
    }
    return count;
}
int result = countNum(arrayNum);
Console.WriteLine($"Число больше 0 => {result}");