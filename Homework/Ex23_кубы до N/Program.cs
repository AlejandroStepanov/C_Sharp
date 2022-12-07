// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();
Console.WriteLine("Enter 'N' : ");
int N = int.Parse(Console.ReadLine());
int[] arr = Enumerable.Range(1, N).ToArray();//создаем массив от 1 до N

for(int i = 0; i<arr.Length; i++)
{
    double j = Math.Pow(arr[i], 3);//вычесляем х^3
    Console.WriteLine($"{arr[i]}^3 = {j}");
}