//Задача 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

// void ReadNumbers(double[] array)
// {
//     for (double i = 0;i < array.Length; i++)
//     {
//         Console.WriteLine("Введите число");
//         array[i] = Convert.ToDouble(Console.ReadLine());
//     }
// }

// Console.WriteLine("Сколько чисел вы будете вводить?");
// double M = Convert.ToDouble(Console.ReadLine());
// double[] arr = new double[M];

// ReadNumbers(arr);

// double HowMuchPos(double[] array)
// {
//     double count = 0;
//     for (double i = 0; i < array.Length; i++)
//     {
//         if (array[i]>0)
//         {
//             count++;
//         }
//     }
//     return count;
// }
// Console.WriteLine(String.Join(", ", arr));
// Console.WriteLine(HowMuchPos(arr));

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите число k1");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число b1");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число k2");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число b2");
double b2 = Convert.ToDouble(Console.ReadLine());

// y = k1 * x + b1;
// y = k2 * x + b2;
// k2*x+b2-(k1*x+b1) = 0;
// k2*x+b2-k1*x-b1=0
// k2*x-k1*x=b1-b2
// (k2-k1)*x=b1-b2
// x = (b1-b2)/(k2-k1)
double x = (b1-b2)/(k2-k1);
double y = k1*x + b1;
Console.WriteLine(Math.Round(x,2) + ", " + Math.Round(y,2));

