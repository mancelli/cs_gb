List<int> cards = new List<int> {1,1,1,1,2,2,2,2,3,3,3,3,4,4,4,4,5,5,5,5,6,6,6,6,7,7,7,7,8,8,8,8,9,9,9,9,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10};
// По правилам Блэкджека, карты J, Q, K стоят по 10 очков. Оставим уусловие, что тузы стоят 1 очко.
List<int> dealer = new List<int>(5); // Карты в руке, как и колоду лучше делать списком, нежели массивом. 
List<int> user = new List<int>(5);  // Ибо массив - штука нединамическая, а карты в процессе игры переходят из cards в dealer или user.
int usersCard, dealersCard; // объявляем эти переменный уровнем выше, т.к. они нам понадобятся не только в цикле.
for (int i = 0; i < 2; i++)     // Т.к. карты раздаются по очереди, то не надо сразу заполнять руки по пять карт. Каждый берет по две карты
{
    usersCard = new Random().Next(0, cards.Count); // Каждый вытягивает карту со случайным индексом из cards
    user.Add(cards[usersCard]);
    cards.RemoveAt(usersCard);          // Карта с этим индексов должна уйти из cards. Т.к. она перешла в руку user
    dealersCard = new Random().Next(0, cards.Count);
    dealer.Add(cards[dealersCard]);
    cards.RemoveAt(dealersCard);  
}
Console.Clear();
Console.WriteLine("Добро пожаловать за стол! Нажмите Enter чтобы начать партию в Блэк-Джек");
Console.ReadLine();
GameTable();
// Cначала ходит игрок!
int sumuser = user[0] + user[1];
while (sumuser < 21 && user.Count < 5)
{ 
    Console.WriteLine("Ваш ход, мсье! (Y чтобы взять еще)");
    string choice = Console.ReadLine(); //Readline и так выдает тип string.
    if (choice.ToLower() == "y")
    {
        //Console.Write(" " + user[user.Count - 1]);
        //sumuser = sumuser + user[user.Count - 1];
        usersCard = new Random().Next(0, cards.Count);
        user.Add(cards[usersCard]);
        cards.RemoveAt(usersCard);
        sumuser += user[user.Count-1];
        GameTable();
    }
    else
        break;
}
int sumdealer = dealer[0]+dealer[1];
if (sumdealer < 16)
{
    dealersCard = new Random().Next(0, cards.Count);
    dealer.Add(cards[dealersCard]);
    cards.RemoveAt(dealersCard);
    sumdealer += dealer[dealer.Count-1];
    GameTable();
}
if (sumuser > sumdealer && sumuser <= 21 || sumuser <= 21 && sumdealer > 21)
{
    Console.WriteLine("Ура! Вы победили!");
}
else if (sumuser < sumdealer && sumdealer <= 21 || sumuser > 21 && sumdealer <= 21)
{
    Console.WriteLine("Победа за казино! Повезет в следующий раз!");
}
else if (sumuser == sumdealer || (sumuser > 21 && sumdealer > 21))
{
    Console.WriteLine("Вы при своих.");
}

void GameTable()
{
    Console.Clear();
    Console.WriteLine("Карты диллера");
    foreach (var dealer in dealer)
    {
        Console.Write($"{dealer} ");
    }
    Console.WriteLine("\n Твои карты");
    foreach (var user in user)
    {
        Console.Write($"{user} ");
    }
    Console.WriteLine();
}
// Console.WriteLine("Ход дилера!");
// 
// 
// Console.WriteLine("Карты дилера ");
// Console.Write(dealer[0]);
// Console.Write(" " + dealer[1]);
// int count = 2; 
// while (sumdealer < 17 && count < 5)
// {
//     Console.Write(" " + dealer[count]);
//     sumdealer = sumdealer + dealer[count];
//     count++;
// }
// Console.WriteLine();
// if (sumdealer>21)
// {
//     Console.WriteLine("Перебор! Вы выиграли!");
//     Console.WriteLine();
// }
// else if (sumdealer>=17 && sumdealer<21)
// {
//     
//     
//    
// }
