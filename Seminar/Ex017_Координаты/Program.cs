// x;y -> zone?
//ввести трёхзначное число -> вторую цифру
Console.Clear();
Console.WriteLine("Введите число X");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число Y");
int y = int.Parse(Console.ReadLine());

if (x > 0 && y > 0)
{
    Console.WriteLine("Zone = 1");
}
if (x < 0 && y > 0)
{
    Console.WriteLine("Zone = 2");
}
if (x < 0 && y < 0)
{
    Console.WriteLine("Zone = 3");
}
if (x > 0 && y < 0)
{
    Console.WriteLine("Zone = 4");
}
if (x == 0 || y == 0)
{
    Console.WriteLine("No than zone");
}
