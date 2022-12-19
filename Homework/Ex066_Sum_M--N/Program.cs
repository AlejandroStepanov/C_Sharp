// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
Console.Write("Введите M: ");
int m=int.Parse(Console.ReadLine());
Console.Write("Введите N: ");
int n=int.Parse(Console.ReadLine());

int SumNtoM(int start, int end)
{
    if (start == end)
    {
        return end;
    }
    return start + SumNtoM(start + 1, end);
}

Console.WriteLine($"Сумма чисел от {m} до {n} = {SumNtoM(m, n)}");

// {

//     if(rank==0)//1
//     {
//         return 1;//n
//     }
//     // rank --;
//     return n * Sum(n,rank-1);

// }