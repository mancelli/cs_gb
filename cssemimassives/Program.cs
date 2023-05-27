// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// double[,] array = new double[4,4];

void FillMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(1,5);
        }
    }
}

double[,] StringsToSmaller(double[,] matrix, int times)
{
    double temp = 0;
    int count = 0;
    while(count<times)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 1; j < matrix.GetLength(1); j++)
            {
                if(count<matrix.GetLength(1)&&matrix[i,j]>matrix[i,j-1])
                {                    
                    temp=matrix[i,j];
                    matrix[i,j] = matrix[i,j-1];
                    matrix[i,j-1] = temp;
                }
            }
        }
        count++;
    }
    return matrix;
}
    


void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(matrix[i,j]<10)
            {
            System.Console.Write($"0{matrix[i,j]} ");
            }
            else
            {
                System.Console.Write($"{matrix[i,j]} ");
            }
        }
        System.Console.WriteLine();
    }
}

// PrintMatrix(array);
// System.Console.WriteLine();
// FillMatrix(array);
// System.Console.WriteLine();
// PrintMatrix(array);
// System.Console.WriteLine();
// StringsToSmaller(array,array.GetLength(1));
// System.Console.WriteLine();
// PrintMatrix(array);


// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.


double[] summary = new double[array.GetLength(1)];

void LowestStringBySummary(double[,] matrix)
{    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            summary[i]+= matrix[i,j]; 
        }
    }
    double min = summary[0];
    int minindex = 0;
    for (int k = 0; k < matrix.GetLength(1); k++)
    {        
        if(summary[k]<min)
        {
            min = summary[k];
            minindex = k;
        }
    }
    for (int l = 0; l < matrix.GetLength(1); l++)
    {
        System.Console.Write($"{matrix[minindex,l]} ");
    }
    System.Console.WriteLine();
}

// PrintMatrix(array);
// System.Console.WriteLine();
// FillMatrix(array);
// System.Console.WriteLine();
// PrintMatrix(array);
// System.Console.WriteLine();
// LowestStringBySummary(array);

// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:

double[,] array = new double[2,2];
double[,] array2 = new double[2,2];

double[,] MatrixProduct(double[,] matrix, double[,] matrix1)
{    
    double[,] prodMatrix = new double[matrix1.GetLength(1),matrix1.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix1.GetLength(1); j++)
            {
                for (int k = 0; k < matrix1.GetLength(0); k++)
                {
                    prodMatrix[i,j] += matrix[i,k] * matrix1[k,j];
                }
            }
        }
    return prodMatrix;
}

// FillMatrix(array);
// System.Console.WriteLine();
// PrintMatrix(array);
// System.Console.WriteLine();

// FillMatrix(array2);
// System.Console.WriteLine();
// PrintMatrix(array2);
// System.Console.WriteLine();
// PrintMatrix(MatrixProduct(array,array2));
// System.Console.WriteLine();



// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2


double[,,] trimassive = new double[2,2,2];

void Fill3dMassiveAndPrintIt(double[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i,j,k] = new Random().Next(10,99);
                System.Console.WriteLine($"{matrix[i,j,k]} ({i},{j},{k})");
            }         
        }
    }
}

// Fill3dMassiveAndPrintIt(trimassive);


// Напишите программу, которая заполнит спирально массив 4 на 4.
double[,] spiral = new double[4,4];

void FillSpiral(double[,] array)
{
    double count=0;
    for (int i = 0, j = 0; j < array.GetLength(0); j++)
    {
        array[i,j] = ++count; 
    }
    for (int i = 1, j = 3; i < array.GetLength(1); i++)
    {
        array[i,j] = ++count; 
    }
    for (int i = 3, j = 2; j>=0; j--)
    {
        array[i,j] = ++count; 
    }
    for (int i = 2, j = 0; i>0; i--)
    {
        array[i,j] = ++count;
    }
    for(int i = 1, j = 1; j<3; j++)
    {
        array[i,j] = ++count;
    }
    for(int i = 2, j = 2; j>0; j-- )
    {
        array[i,j] = ++count;
    }
}

// PrintMatrix(spiral);
// System.Console.WriteLine();

// FillSpiral(spiral);

// PrintMatrix(spiral);

