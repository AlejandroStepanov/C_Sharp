// **Задача 40:**Напишите программу, 
// которая принимает на вход три числа и проверяет, может ли 
// существовать треугольник с сторонами такой длины.


// ❗ **Теорема о неравенстве треугольника:
// **каждая сторона треугольника меньше суммы двух других сторон.

Console.Clear();
Console.Write("Введите стороны треугольника через пробел: ");

string[] st = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
int a = int.Parse(st[0]), b = int.Parse(st[1]), c = int.Parse(st[2]);

bool Triangle(int a, int b, int c)
{
    return (a < (b + c) && b < (a + c) && c < (a + b));
}

if (Triangle(a, b, c))
Console.WriteLine("Yes");
else Console.WriteLine("No");