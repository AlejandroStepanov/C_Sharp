//определение четности числа
Console.Clear();
Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());

if(a%2 == 0)
{
    Console.WriteLine("Это чётное число.");  
}else{
    Console.WriteLine("Это нечётное число."); 
}