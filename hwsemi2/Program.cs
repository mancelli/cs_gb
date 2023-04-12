// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.WriteLine("Введите трехзначное число");
// int num = Convert.ToInt32(Console.ReadLine());

// int flet = num /100;
// int temp = num %100;
// int tlet = temp %10;
// int slet = (temp - tlet)/10;

// Console.WriteLine("Вторая цифра введенного числа равна " + slet);




// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

// Console.Clear();
// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// int temp = num;
// int length1 = 0;
// while(num >0)
// {
//     num = num /10;
//     length1++;
// }
// double length2 = Convert.ToDouble(length1);
// num = temp;
// int pow = 0;
// if (length2 > 2)
// {
//     pow = Convert.ToInt32(Math.Pow(10, (length2-2)));
//     num = num %pow;
//     num = num /(pow/10);
//     Console.WriteLine("Третья цифра введенного числа равна " + num);
// }
// else
// {
//     Console.WriteLine("У данного числа нет третьей цифры");
// }


// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

// Console.WriteLine("Введите цифру, обозначающую день недели");
// int day = Convert.ToInt32(Console.ReadLine());
// if(day<8 && day>0)
// {
//     if (day = 6||day = 7)
//     {
//         Console.WriteLine("Ура! Это выходной!");
//     }    
//     else 
//     {
//         Console.WriteLine("Это будний день.")
//     }
// }
// else
// {
//     Console.WriteLine("Эта программа только для землян! Земная неделя длится 7 дней!");
// }