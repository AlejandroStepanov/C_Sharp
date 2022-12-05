Console.Clear();
Console.Write("Введите N: ");
int n = int.Parse(Console.ReadLine());


// while(i <= n)
// {
//     Console.Write($"{Math.Pow(i, 2)} ");
//     i+=1;
// }

for (int i = 1; i <= n; i++)
{
    Console.Write($" {i * i} ");
}
