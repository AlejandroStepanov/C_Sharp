// **Задача 65:**Задайте значения M и N.
//  Напишите программу, которая выведет все
//   натуральные числа в промежутке от M до N.

// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 5, 6, 7, 8"

using System;
using static System.Console;

Clear();
// Write("Введите N: ");
// int i = int.Parse(ReadLine());
// Write("Введите M: ");
// int j = int.Parse(ReadLine());

// FooVpered(1, 8);

// void FooVpered(int i, int j)
// {
//     Console.Write(i);
//     if (i == j)
//     {

//         return;
//     }
//     i++;
//     FooVpered(i, j);
// }

string MtoN(int start, int end)
{
    if (start == end)
    {
        // Console.WriteLine(start.ToString);
        return start.ToString();
    }

    string s = start + " " + MtoN(start + 1, end);
    // Console.WriteLine(s);
    return start + " " + MtoN(start + 1, end);

}

Console.WriteLine(MtoN(1, 7));




// void FooVpered(int i, int j)
// {
//     Console.Write(i);
//     if (i < j)
//     {
//         FooVpered(i+1, j);
//     }
// }

// FooVpered(3, 9);

// void FooNazad(int n)
// {
//     Console.Write($"{n} ");
//     if(n>=1)
//     {
//         FooNazad(n-1);
//     }
// }

// FooNazad(6);

// void a(int n)
// {
//     if (n >= 1)
//     {
//         a(n - 1); //Уменьшает до минимума и при закрытии каждой функции выводит на печать
//         Console.Write(n);
//     }
// }
// a(7);

