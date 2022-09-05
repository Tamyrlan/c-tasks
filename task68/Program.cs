Console.Write("Введите первое число m:");
int firstnum = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число n:");
int secondnum = Convert.ToInt32(Console.ReadLine());

int Akkerman(int num1, int num2)
{
    if (num1 == 0) return num2 + 1;
    else
    {
        if ((num1 != 0) && (num2 == 0)) return Akkerman(num1-1,1);
        else return Akkerman(num1-1,Akkerman(num1,num2-1));
    }
}

int res = Akkerman(firstnum, secondnum);
Console.WriteLine($" A(m,n) = {res}");