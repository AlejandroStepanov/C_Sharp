Console.Clear();
Console.WriteLine("Сколько ЗНАКОВ в числе?: ");
int count = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());

int[] array = new int[count]; //Заполняем

for (int i = count - 1; i >= 0; i = i - 1)
{
    array[i] = num % 10;
    num = num / 10;
}

string Pol(int[] array)
{
    string result = string.Empty;
    int lastInx = array.Length - 1;

    for (int i = 0; i < array.Length / 2; i++, lastInx--)
    {
         if (array[i] != array[lastInx])
        {
            result = result + "NOT";
            return result;
        }
    }
    result = result + "IS";
    return result;

}
string YorN = Pol(array);
Console.WriteLine($"The entered value {YorN} palindrom.");


// i = 0;
// while (i < array.Length / 2)
// {
//     if (array[i] == array[count - 1])
//     {
//         i++;
//         count--;
//     }
//     else
//     {
//         Console.WriteLine($"Число {a} не палиндром");
//         break;
//     }
//     Console.WriteLine($"Число {a} палиндром");
//     break;
// }