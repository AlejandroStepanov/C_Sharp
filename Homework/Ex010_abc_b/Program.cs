//ввести трёхзначное число -> вторую цифру
Console.Clear();
Console.WriteLine("Введите трёхзначное число");
int num = int.Parse(Console.ReadLine ());

if(num >99 && num < 1000)
{
  Console.WriteLine($"Вторая цифра: {num%10}");  
}
else
{
    Console.WriteLine($"Число {num} не является трёхзначным!");
}
