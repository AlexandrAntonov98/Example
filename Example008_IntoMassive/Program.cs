int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}

int a1 = 124433;
int b1 = 123344;
int c1 = 13;

int a2 = 2133;
int b2 = 2234;
int c2 = 234353;

int a3 = 314546;
int b3 = 3332;
int c3 = 3;

int Max1 = Max(a1, b1, c1);
Console.WriteLine("Покажи максимальный результат первой тройки: " + Max1);

int Max2 = Max(a2, b2, c2);
Console.WriteLine("Покажи максимальный результат второй тройки: " + Max2);

int Max3 = Max(a3, b3, c3);
Console.WriteLine("Покажи максимальный результат третьей тройки: " + Max3);

int Win = Max(Max1, Max2, Max3);
Console.WriteLine("Покажи победителя: " + Win);
