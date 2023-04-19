// Console.WriteLine("Введите число х");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число y");
// int y = Convert.ToInt32(Console.ReadLine());

// if (x>0 && y>0)
// {
//     Console.WriteLine("Координата находится в первой четверти");
// }
// else if (x<0 && y>0)
// {
//     Console.WriteLine("Координата находится во второй четверти");
// }
// else if (x<0 && y<0)
// {
//     Console.WriteLine("Координата находится во третьей четверти");
// }
// else if (x>0 && y<0)
// {
//     Console.WriteLine("Координата находится в четвертой четверти");
// }
// else
// {
//     Console.WriteLine("Некорректные данные!");
// }

// Задача 18: Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

// Console.WriteLine("Введите номер четверти");
// int chet = Convert.ToInt32(Console.ReadLine());

// if (chet = 1)
// {
//     Console.WriteLine("Диапазон y>0, x>0 );

// }
// else if (chet = 2)
// {
//     Console.WriteLine("Диапазон y>0, x<0 );

// }
// else if (chet = 3)
// {
//     Console.WriteLine("Диапазон y<0, x<0 );

// }
// else if (chet = 4)
// {
//     Console.WriteLine("Диапазон y<0, x>0 );

// }

// Console.WriteLine("Введите номер четверти");
// int chet = Convert.ToInt32(Console.ReadLine());

// switch(chet)
// {
//     case 1:
//     {
//         Console.WriteLine("Диапазон y>0, x>0" );
//         break;
//     }
//     case 2:
//     {
//         Console.WriteLine("Диапазон y>0, x<0" );
//         break;
//     }
//     case 3:
//     {
//         Console.WriteLine("Диапазон y<0, x<0" );
//         break;
//     }
//     case 4:
//     {
//         Console.WriteLine("Диапазон y<0, x>0" );
//         break;
//     }
//     default:
//     {
//         Console.WriteLine("Такой четверти нет" );
//         break;
//     }        
// }

// int num = 6;
// Console.WriteLine(num==8);




// Console.WriteLine("Введите координату 1 по оси х");
// int A1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату 2 по оси х");
// int B1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату 1 по оси y");
// int A2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату 2 по оси y");
// int B2 = Convert.ToInt32(Console.ReadLine());


// int cat1 = 0;
// int cat2 = 0;

// if(A1>B1)
// {
//     cat1 = A1 - B1;
// }
// else if (A1<B1)
// {
//     cat1 = B1 - A1;
// }
// if (A2 > B2)
// {
//     cat2 = A2 - B2;
// }
// else if (A2<B2)
// {
//     cat2 = B2 - A2;
// }

// double cat3 = Math.Sqrt(Convert.ToDouble((cat1*cat1)+(cat2*cat2)));
// cat3 = Math.Round(cat3,2);

// Console.WriteLine("Расстояние от точки 1 до точки 2 равно " + cat3);
// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// for(int i=1;i<=num;i++)
// {
//     Console.Write(Math.Pow(i,2) + " ");
// }

Console.WriteLine("Введите пятизначное число");
int pal = Convert.ToInt32(Console.ReadLine());
int temp = pal;
if (pal>9999 && pal<100000)
{
    int num1 = pal/10000;
    int num2 = pal%10;
    if(num1 == num2)
    {
        pal = pal-(num1*10000+num2);
        num1 = pal/1000;
        num2 = (pal%100)/10;
        
        if(num1 == num2)
        {
            Console.WriteLine($"Число {temp} является палиндромом!");
        }
            else
        {
        Console.WriteLine($"Число {temp} не является палиндромом!");
        }
    }
    else
    {
        Console.WriteLine($"Число {temp} не является палиндромом!");
    }

}
else
{
    Console.WriteLine("Число не пятизначное!");
}