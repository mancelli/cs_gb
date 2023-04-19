// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

// Console.WriteLine("Введите число");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите степень");
// int b = Convert.ToInt32(Console.ReadLine());
// int temp = a;
// int Pow(int a, int b)
// {
//     for(int i = 1; i<b; i++)
//     {
//         temp = temp*a;
//     }
//     return temp;
// }

// Console.WriteLine(Pow(a, b));

// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

// Console.WriteLine("Введите число");
// string num = Convert.ToString(Console.ReadLine());

// int SummaryByChar(string str)
// {   
//     int length = str.Length;
//     int sum = 0;
//     for (int i = 0; i < length; i++)
//     {
        
//         int temp = str[i] - '0'; // почему-то без части -'0' не выходит ничего, присваивается номер в таблице символов, а не само значение символа. 
//         sum = sum + temp;
//         Console.WriteLine(sum);

//     }
//     return sum;
// }

// Console.WriteLine($"Сумма цифр в этом числе равна {SummaryByChar(num)}");


// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]



int[] arr = new int[8]; //инициализируем пустой массив на 8 элементов.

void WriteToArray(int[] array) //записываем в массив введенные пользователем числа
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        Console.WriteLine($"Введите {i+1} число");
        int num = Convert.ToInt32(Console.ReadLine());
        array[i] = num;
    }
}

void PrintArray(int[] array) // метод вывода двух массивов случайного размера не более 8 элементов по порядку введения пользователем.
{
    int rand = new Random().Next(1,8); // первый массив не может иметь более 7 элементов
    int[] arr1 = new int[rand];
    int[] arr2 = new int[8-rand]; // второй массив имеет длину ровно на остаток чисел.
    int length1 = arr1.Length;
    for (int i = 0; i < length1; i++)
    {
        arr1[i] = array[i];
    }
    int length2 = arr2.Length;
    for (int i = 0; i < length2; i++)
    {
        arr2[i] = array[length1];
        length1++;
    }
    Console.Write("[");
    Console.Write(string.Join(',', arr1));
    Console.Write("]");
    Console.WriteLine();
    Console.WriteLine();
    Console.Write("[");
    Console.Write(string.Join(',', arr2));
    Console.Write("]");
    Console.WriteLine();
}

Console.Clear();

WriteToArray(arr);
PrintArray(arr);
