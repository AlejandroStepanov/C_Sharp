// ввести число с консоли, возвести число в квадрат (number*number)
Console.Clear();
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
int sqr=number*number;
Console.WriteLine($"Квадрат числа {number} = {sqr}");

//Решение с использ. библиотеки.
int sqr1=Convert.ToInt32(Math.Pow(number, 2)); //Посмотреть Pow 
Console.WriteLine($"Квадрат числа {number} = {sqr1}");
double number2 = 3.9;
double sqr2=(Math.Pow(number2, 2));
Console.WriteLine($"Квадрат числа {number2} = {Math.Round(sqr2, 2)}"); // time 1:05:17