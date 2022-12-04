// Вывести четные от 1 до N
Console.Clear();
Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine($"Вы ввели чило: {N}");
int a = 1;
Console.Write($"Чётные числа от 1 до {N}: ");

while(a <= N)
{
   if(a % 2 == 0)
   {
    Console.Write($"{a} ");
   }
    a++;
}
