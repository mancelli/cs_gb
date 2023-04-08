// программа которая на вход принимает два числа и выдает большее из них

// Console.WriteLine("Введите первое число");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int num2 = Convert.ToInt32(Console.ReadLine());

// int max = num1;
// if (num2 > max)
// {
//     max = num2;
// }

// Console.Write("Вот наибольшее число:");
// Console.WriteLine(max);

//программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел

Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;
if (max < num2)
{
    max = num2;
}
if (max < num3)
{
    max = num3;
}

Console.Write("Вот наибольшее число:");
Console.WriteLine(max);