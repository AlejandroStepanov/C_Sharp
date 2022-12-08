// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();
Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine($"{a}^{b} = {Cube(a, b)}");

int Cube(int x, int y)
{
    int count = 1;
    for (int i = 1; i <= y; i++)
    {
        count = count * x;
    }
    return count;
}
