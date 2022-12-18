//Напишите программу, которая будет принимать на вход 
//число и возвращать сумму его цифр.

using System;
using static System.Console;

Clear();
Write("Введите N: ");
int n = int.Parse(ReadLine());
Console.WriteLine($"{n} -> {Sum(n)}");

int Sum(int n)
{
    if(n==0)
    {
        return n;// поставить n or 0
    }

    return n % 10 + Sum(n/10);

}