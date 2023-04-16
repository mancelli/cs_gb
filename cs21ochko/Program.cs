int[] cards = {1,1,1,1,2,2,2,2,3,3,3,3,4,4,4,4,5,5,5,5,6,6,6,6,7,7,7,7,8,8,8,8,9,9,9,9,10,10,10,10,11,11,11,11,12,12,12,12,13,13,13,13};

int[] Fill(int[] array)
{
    for (int i = 0; i<5; i++)
    {
        int index = new Random().Next(0,52);
        array[i] = cards[index];
        cards[index] = 0;
        while (array[i] == 0)
        {
            array[i] = cards[index+1];
            if (index>51)
            {
                index = 0;
            }
            cards[index+1] = 0;
        }     
    }
    return array;
}

bool Perebor(int summary)
{
    if (summary<22)
    {
        return false;
    }
    else
    {
        return true;
    }
}


int[] dealer = new int[5];
int[] user = new int[5];

Fill(dealer);
Fill(user);


Console.Clear();
Console.WriteLine("Добро пожаловать за стол! Нажмите Enter чтобы начать партию в Блэк-Джек");
Console.ReadLine();
Console.WriteLine("Карты дилера ");
Console.Write(dealer[0]);
Console.Write(" " + dealer[1]);
Console.ReadLine();
int sumdealer = dealer[0]+dealer[1];
Console.WriteLine();
Console.WriteLine("Твои карты ");
Console.Write(user[0]);
Console.Write(" " + user[1]);
int sumuser = user[0]+user[1];
Console.ReadLine();
if (Perebor(sumuser) == true)
{
    Console.WriteLine();
    Console.WriteLine("У вас перебор! Увы, вы проиграли!");
    if (Perebor(sumuser) == true && Perebor(sumdealer) == true)
    {
    Console.WriteLine("Но у дилера тоже перебор, так что не важно :)");
    Console.WriteLine();
    }
}
else
{
    Console.WriteLine("Ход дилера!");
    Console.WriteLine("Карты дилера ");
    Console.Write(dealer[0]);
    Console.Write(" " + dealer[1]);
    int count = 2; 
    while (sumdealer < 17 && count < 5)
    {
        Console.Write(" " + dealer[count]);
        sumdealer = sumdealer + dealer[count];
        count++;
    }
    Console.WriteLine();
    if (Perebor(sumdealer) == true)
    {
        Console.WriteLine("Перебор у дилера! Вы выиграли!");
        Console.WriteLine();
    }
    else if (sumdealer>=17 && sumdealer<22)
    {
        Console.WriteLine("Достаточно! Ваш ход, мсье! (Y чтобы взять еще)");
        string choice = Convert.ToString(Console.ReadLine());
        int i = 2;
        Console.WriteLine();
        Console.WriteLine("Твои карты ");
        Console.Write(user[0]);
        Console.Write(" " + user[1] + " ");
        while (choice == "Y" && sumuser<22 && i<5)
        {
            Console.Write(user[i]+ " ");
            sumuser = sumuser + user[i];
            i++;
            if (sumuser>21)
            {
                Console.WriteLine();
                Console.WriteLine("Перебор! Увы, вы проиграли!");
                break;
            }
            if (i>4)
            {
                Console.WriteLine();
                Console.WriteLine("Вы не можете взять больше 5 карт!");
                break;
            }
            Console.WriteLine();
            choice = Console.ReadLine();
        }
        if (sumuser > sumdealer && sumuser <22)
        {
            Console.WriteLine();
            Console.WriteLine("Ура! Вы победили!");
        }
        else if (sumuser<sumdealer && sumdealer<22)
        {
            Console.WriteLine();
            Console.WriteLine("Победа за казино! Повезет в следующий раз!");
        }
        else if (sumuser == sumdealer || (sumuser>21 && sumdealer>21))
        {
            Console.WriteLine();
            Console.WriteLine("Вы при своих.");
        }
    }
}