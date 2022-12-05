//Напишите программу, 
//которая принимает на вход координаты двух точек и находит 
//расстояние между ними в 2D пространстве.

//A (3,6); B(2, 1)-> 5,09
//A(7, -5); B(1, -1)-> 7,21

Console.Clear();
Console.Write("Введите X1: ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("Введите Y1: ");
int y1 = int.Parse(Console.ReadLine());
Console.Write("Введите X2: ");
int x2 = int.Parse(Console.ReadLine());
Console.Write("Введите Y2: ");
int y2 = int.Parse(Console.ReadLine());

double d = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));

Console.WriteLine($"d={d:f3}");

// double n = Math.Sqrt(Math.Pow(9-4, 2) + Math.Pow (7-3, 8));
// Console.Write($"{n:f3}");