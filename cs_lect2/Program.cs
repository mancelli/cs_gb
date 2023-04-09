void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1,10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int pos = 0;
    while (pos < count)
    {
        Console.WriteLine(col[pos]);
        pos++;
    }
}

int IndexOf(int[] collect, int find)
{
    int size = collect.Length;
    int ind = 0;
    int position = -1;
    while(ind < size)
    {
        if(collect[ind] == find)
        {
            position = ind;
        }
        ind++;
        
    }
    return position;
}


int[] array = new int[10];

FillArray(array);
PrintArray(array);

Console.WriteLine("Введите число от 1 до 9 чтобы найти его место среди чисел выше");
int choice = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine(IndexOf(array, choice)+1);
