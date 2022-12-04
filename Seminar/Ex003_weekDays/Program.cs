Console.Clear();
Console.WriteLine("Введите чмсло от 1 до 7: ");
int a = int.Parse(Console.ReadLine());
if(a == 1)
{
    Console.WriteLine("Monday!");
}
if(a == 2)
{
    Console.WriteLine("Tuesday!");
}
if(a == 3)
{
    Console.WriteLine("Wednesday!");
}
if(a == 4)
{
    Console.WriteLine("Thursday!");
}
if(a == 5)
{
    Console.WriteLine("Friday!");
}
if(a == 6)
{
    Console.WriteLine("Saturday!");
}
if(a == 7)
{
    Console.WriteLine("Sunday!");
}else{
    Console.WriteLine("Тебе же написали, от 1 до 7! Ты не умеешь читать?!");}