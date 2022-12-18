//Напишите программу, которая на вход принимает два числа A и B, 
//и возводит число А в целую степень B с помощью рекурсии.
//a = 3; b = 5 -> 243 (3^5) 3*3*3*3*3

using System;
using static System.Console;

Clear();
Write("Введите число: ");
int n = int.Parse(ReadLine());
Write("Введите чтепень: ");
int rank = int.Parse(ReadLine());
Console.WriteLine($"{Sum(n,rank)}");

int Sum(int n, int rank)
{

    if(rank==0)//1
    {
        return 1;//n
    }
    // rank --;
    return n * Sum(n,rank-1);

}