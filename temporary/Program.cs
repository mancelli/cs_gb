// void GenerateArray(int[] Array)
// {
//     int index = 0;
//     int size = array.Length;
//     while(index<size)
//     {
//         array[index] = new Random().Next(10,100);
//         index++;
//     }
// }
// int rand = new Random().Next(100,1000);
// Console.WriteLine(rand);

// int fnum = rand /100;
// int temp = rand %10;
// int tnum = temp %10;

// Console.Write($"{fnum}{tnum}");

// double a = 19;
// double b = a/8;
// double c = a%8;
// Console.Write($"{a}, {b}, {c}");

// Console.WriteLine("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());
// int result1 = number %7;
// int result2 = number %23;

// if ((result1 == 0)&&(result2 == 0))
// {
//     Console.WriteLine($"Введенное число {number} кратно и 7 и 23 одновременно!");
// }

// Console.WriteLine("Введите 1 число");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите 2 число");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if (num2 == num1*num1)
// {
//     Console.WriteLine("Число 2 является квадратом числа 1");
// }
// else if (num1 == num2*num2)
// {
//     Console.WriteLine("Число 1 является квадратом числа 2");
// }
// else
// {
//     Console.WriteLine("Числа несовместимы");
// }

// string s = "Понятие «содержание высказывания» связано с категорией информативности речи и присуще только тексту. Оно сообщает читателю индивидуально-авторское понимание отношений между явлениями, их значимости во всех сферах придают ему смысловую цельность." + 

// "В большом тексте ведущая тема распадается на ряд составляющих подтем; подтемы членятся на более дробные, на абзацы (микротемы)."+

// "Завершённость высказывания связана со смысловой цельностью текста. Показателем законченности текста является возможность подобрать к нему заголовок, отражающий его содержание."+

// "Таким образом, из смысловой цельности текста вытекают следующие признаки текста:";

// Console.WriteLine(s);

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;

//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if(text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }
//     return result;
// }

// s = Replace(s, 'к', 'К');
// Console.WriteLine(s);

int[] arr = new int[10];

void GenerateArray(int[] array)
{
    for(int i = 0; i<array.Length; i++)
    {
        int temp = new Random().Next(1,10);
        array[i] = temp;
    }
}

void PrintArray(int[] array)
{
    int count = array.Length;

    for(int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
Console.Clear();
GenerateArray(arr);
PrintArray(arr);

void Sort(int[] array)
{
    for(int i =0; i <array.Length; i++)
    {
        int minPos=i;
        for (int j = i+1; j< array.Length; j++)
        {
            if(array[j]<array[minPos])
            {
                minPos = j;
            }
        }

        int temporary = array[i];
        array[i] = array[minPos];
        array[minPos] = temporary;
    }
}
Sort(arr);
PrintArray(arr);