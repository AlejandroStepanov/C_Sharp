// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
//  заданных уравнениями 
//  y = k1 * x + b1, 
//  y = k2 * x + b2; 
//  значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.Clear();
Console.Write("Введите 'b1' , 'k1' , 'b2' , 'k2' через пробел: ");
string[] text = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
double b1 = double.Parse(text[0]), k1 = double.Parse(text[1]),
       b2 = double.Parse(text[2]), k2 = double.Parse(text[3]);

void DotCross(double b1, double k1, double b2, double k2)
{
    double x = 0;
    double y = 0;

    if ((k1 == k2) && (b1 == b2) || (k1 == k2))
    {
        Console.WriteLine("Прямые не пересекаются");
    }
    else
    {
        x = (b2 - b1) / (k1 - k2);
        y = (k1 * (b2 - b1)) / (k1 - k2) + b1;
        Console.WriteLine($"The dot of cross is: x = {x} ; y = {y}");
    }
}

DotCross(b1, k1, b2, k2);
