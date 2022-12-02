Console.WriteLine("Првиет! Как тебя зовут?");
string user = Console.ReadLine();
if(user.ToLower() == "маша")
{
    Console.WriteLine("Ура, это же Маша!");
}
else
{
   Console.Write("А, это снова ");
   Console.WriteLine(user);
}