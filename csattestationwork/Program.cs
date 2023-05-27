//  Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

void PrintToLesser(int N)
{
    if(N<1)
    {
        return;
    }
    Console.Write($"{N} ");
    PrintToLesser(N-1);    
}

PrintToLesser(5);

// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
System.Console.WriteLine();
int summary = 0;
void SummaryByArray(int M, int N)
{
    if(M>N)
    {
        Console.Write($" {summary}");
        return;
    }
    summary+=M;
    Console.Write($"{M} ");
    SummaryByArray(M+1,N);
}

SummaryByArray(1,4);


