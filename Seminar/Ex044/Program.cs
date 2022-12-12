// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи.
//  Первые два числа Фибоначчи: 0 и 1.

// Если N = 5-> 0 1 1 2 3

// Если N = 3 -> 0 1 1

// Если N = 7 -> 0 1 1 2 3 5 8

Console.Clear();
int number = int.Parse(Console.ReadLine());
f(number);

void f(int countTests)
{
    int fibonacci1 = 0;
    int fibonacci2 = 1;
    Console.Write($"f({0}) = {0}; ");
    for (int i = 1; i < countTests; i++)
    {
        Console.Write($"f({i}) = {fibonacci2}; ");
        int temporary = fibonacci2;
        fibonacci2 += fibonacci1;
        fibonacci1 = temporary;
    }
}