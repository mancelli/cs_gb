// Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).
// Например:
// 4 -> 16 
// -3 -> 9 
// -7 -> 49

Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());

if (a == b*b)
{
    Console.WriteLine("Число 1 является квадратом числа 2");
}
else
{ 
    if (b == a*a)
    {
        Console.WriteLine("Число 2 является квадратом числа 1");
    }
    else
    {
        Console.WriteLine("Несовместимые числа");
    }
}
