// Сумма от 1 до N
Console.Clear();
Console.WriteLine("Enter the number: ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма чисел от 1 до {N} = {Sum(N)}");

int Sum(int N)
{
    int result = 0;
    for (int i = 1; i <= N; i++)
    {
        result +=i;
    }
    return result;
}
