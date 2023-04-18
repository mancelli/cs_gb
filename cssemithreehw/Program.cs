//Проверка на палиндром

Console.WriteLine("Введите пятизначное число");
int pal = Convert.ToInt32(Console.ReadLine());
int temp = pal;
if (pal>9999&&pal<100000)
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

// ввод Координаты двух точек в 3д пространстве и вывод расстояние между ними. 

Console.WriteLine("Введите координату а по x");
int AX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату а по y");
int AY = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату а по z");
int AZ = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату b по x");
int BX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату b по y");
int BY = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату b по z");
int BZ = Convert.ToInt32(Console.ReadLine());

double distance = Math.Sqrt(Convert.ToDouble(((AX-BX)*(AX-BX))+((AY-BY)*(AY-BY)+((AZ-BZ)*(AZ-BZ)))));
distance = Math.Round(distance, 2);

Console.WriteLine("Расстояние между этими точками в трехмерном пространстве равно " + distance);

// Ввод число N вывод таблица кубов от 1 до N.

Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= N; i++)
{
    int cube = Convert.ToInt32(Math.Pow(Convert.ToDouble(i),3));
    Console.Write(cube + " ");

}
