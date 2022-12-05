Console.Clear();
Console.WriteLine("Enter the number");
int N = int.Parse(Console.ReadLine());
int B = -N;
while (B <= N)
{
    Console.WriteLine($"{B}");
    B++;
}