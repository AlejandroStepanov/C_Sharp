Console.Clear();
Console.WriteLine("Сколько ЗНАКОВ в числе?: ");
int count = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
int a = num;

int[] array = new int[count];
int i = count - 1;

while (i >= 0)
{
    array[i] = num % 10;
    num = num / 10;
    i = i - 1;
}
// i = 0;
// while (i<array.Length)
// {
//     Console.Write($"{array[i]} ");
//     i++;
// }

i = 0;
while (i < array.Length / 2)
{
    if (array[i] == array[count - 1])
    {
        i++;
        count--;
    }
    else
    {
        Console.WriteLine($"Число {a} не палиндром");
        break;
    }
    Console.WriteLine($"Число {a} палиндром");
    break;
}