// int[] array = new int[new Random().Next(10)];//задача 34
// int num = 0;

// for (int i = 0; i < array.Length; i++)
// {    
//     array[i] = new Random().Next(100,1000);
//     if (array[i]%2 == 0)
//     {
//         num+=1;
//     }
// }
// Console.WriteLine(String.Join(", ", array));
// Console.WriteLine(num);


// int[] array = new int[new Random().Next(10)];//задача 36
// int sum = 0;
// for (int i = 0; i < array.Length; i++)
// {    
//     array[i] = new Random().Next(100,1000);
//     if(i%2 !=0)
//     {
//         sum+=array[i];
//     }
// }
// Console.WriteLine(String.Join(", ", array));
// Console.WriteLine(num);

double[] array = new double[new Random().Next(2, 10)];//задача 38
double max = 0; 
double min = 0;
double num = 0;

for (int i = 0; i < array.Length; i++)
{   
    array[i] = new Random().Next(-100,101) + new Random().NextDouble();
    array[i] = Math.Round(array[i], 2);
    if(array[i] > max)
    {
        max = array[i];
    }
    else if (array[i]< min)
    {
        min = array[i];
    }
}

if(min<0)
{
    num = max+min;
}
else
{
    num = max-min;
}
Console.WriteLine(String.Join(", ", array));
Console.WriteLine(Math.Round(num, 2));