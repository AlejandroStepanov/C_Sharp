// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до M.
//  Выполнить с помощью рекурсии.

// M = 5; N = 3 -> "5, 4, 3"
// M = 8; N = 4. -> "8, 7, 6, 5, 4"
using System;
using static System.Console;

Clear();
Write("Введите N: ");
int n=int.Parse(ReadLine());
Write("Введите M: ");
int m=int.Parse(ReadLine());

string MtoN(int start, int end)
{
    if (end == start)
    {
        return end.ToString();
    }
    return end + " " + MtoN(start, end-1);

}

Console.WriteLine(MtoN(m, n));


// void a(int n)
// {
//     if (n >= 1)
//     {
//         a(n - 1); //Уменьшает до минимума и при закрытии каждой функции выводит на печать
//         Console.Write(n);
//     }
// }
// a(7);

// void FooNazad(int n)
// {
//     Console.Write($"{n} ");
//     if(n>=1)
//     {
//         FooNazad(n-1);
//     }
// }

// FooNazad(6);