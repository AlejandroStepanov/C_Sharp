//Если есть, вывести третью цифру числа N.
Console.Clear();
Console.Write("Enter a number: ");
int n = int.Parse(Console.ReadLine());
//    Console.WriteLine("Число не имеет третьей цифры.");

while (n > 1000)
{
    n = n / 10;
}
if (n > 100 && n < 1000)
{
    Console.Write($"{n} -> {n % 10}");
}
else
{
    Console.WriteLine("Число не имеет третьей цифры.");
}
