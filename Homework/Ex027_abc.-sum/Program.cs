// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.Clear();
Console.WriteLine("Enter the number: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма цифр {num} = {NumToSum(num)}");

int NumToSum(int value)
{
    int result = 0;
    for (result = 0; value > 0; value = value / 10)
    {
        result = result + value % 10;
    }
    return result;
}


// NumToArr(num);

// int[] NumToArr(int number)
// {
//     int size = num.ToString().Length;
//     int[] newarray = new int[size];
//     for (int i = newarray.Length - 1; i >= 0; i--)
//     {
//         newarray[i] = number % 10;
//         number /= 10;
//     }
//     return newarray;
// }