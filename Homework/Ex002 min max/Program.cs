Console.Clear();
Console.WriteLine("Введите a: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите b: ");
int b = int.Parse(Console.ReadLine());

if(a > b)
{
    Console.WriteLine($"Max = {a}, Min = {b}");
}else{
    Console.WriteLine($"Max = {b}, Min = {a}");
}    