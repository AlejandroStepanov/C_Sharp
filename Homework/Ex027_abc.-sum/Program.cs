// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.Clear();
Console.WriteLine("Enter the number: ");
int num = int.Parse(Console.ReadLine());
int a = num;
int length =  num.ToString().Length;
int[] array = new int[length];

for(int i = length -1; i>=0; i--)
{
    array[i] = num%10;
    num = num/10;
}

// void PrintArray(int[] col)
// {
//     int count = col.Length;
//     int position = 0;
//     while (position<count)
//     {
//         Console.Write($"{col[position]} ");
//         position++;
//     }
// }
// PrintArray(array);


int Sum(int[] array)
{
    int result = 0;
    for(int j = 0; j<array.Length; j++)
    {
      result = result + array[j];  
    }
    return result;
}
int sum = Sum(array);

Console.WriteLine($"Сумма цифр числа '{a}' = {sum}");
