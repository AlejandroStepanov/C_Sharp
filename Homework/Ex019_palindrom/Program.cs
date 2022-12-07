Console.Clear();
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
int CountArr =  num.ToString().Length;
int[] array = new int[CountArr]; //создали массив


for (int i = CountArr - 1; i >= 0; i = i - 1)//Заполняем
{
    array[i] = num % 10;
    num = num / 10;
}

string Pol(int[] array) //метод index == LastIndex ?
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
string YorN = Pol(array);//прменение метода
Console.WriteLine($"The entered value {YorN} palindrom.");//печать метода







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