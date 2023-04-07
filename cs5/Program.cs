Console.WriteLine("Веедите свое имя");
string username = Console.ReadLine();

if(username.ToLower() == "миша")
{
    Console.WriteLine("Ура, это же Миша!");
}
else
{
    Console.WriteLine("Привет, ");
    Console.WriteLine(username);
}