// System.Console.WriteLine("Введите число строк таблицы");// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// int m = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите число столбцов таблицы");
// int n = Convert.ToInt32(Console.ReadLine());

// double[,] matrix = new double[m,n];


// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i,j] = Math.Round(new Random().Next(-100,101) + new Random().NextDouble(), 2);
//     }
// }
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         Console.Write($"{matrix[i,j]} ");
//     }
//     System.Console.WriteLine();
// }



// System.Console.WriteLine("Введите номер строки");// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//                                                         // и возвращает значение этого элемента или же указание, что такого элемента нет.
// int m = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите номер столбца");
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] matrix = new int[new Random().Next(2,10),new Random().Next(2,10)];//задаем массив


// for (int i = 0; i < matrix.GetLength(0); i++)//заполняем
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i,j] = new Random().Next(-10,11);
//     }
// }
// for (int i = 0; i < matrix.GetLength(0); i++)//выводим массив
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         Console.Write($"{matrix[i,j]} ");
//     }
//     System.Console.WriteLine();
// }

// System.Console.WriteLine("_____________");
// System.Console.WriteLine();
// if (m < matrix.GetLength(0)&& n< matrix.GetLength(1)&&m>=0&&n>=0) System.Console.WriteLine(matrix[m,n]);//проверяем корректность ввода и выводим нужный элемент.
// else {System.Console.WriteLine("Элемент с заданными параметрами не существует");}//если некорректно выводим ошибку.


int[,] matrix = new int[new Random().Next(2,10),new Random().Next(2,10)]; //Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
double ma = 0;

for (int i = 0; i < matrix.GetLength(0); i++)//заполняем и выводим массив.
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = new Random().Next(1,10);
        System.Console.Write($"{matrix[i,j]} ");
    }
    System.Console.WriteLine();
}
System.Console.WriteLine();
for (int i = 0; i < matrix.GetLength(1); i++)//находим среднее арифметическое каждого столбца и выводим его в отдельной строке. 
{
    for (int j = 0; j < matrix.GetLength(0); j++)
    {
        ma += matrix[j,i];
    }
    ma = Math.Round(ma/matrix.GetLength(0),2);
    System.Console.WriteLine($"{ma} - среднее арифметическое столбца {i+1}");
    ma = 0;
}