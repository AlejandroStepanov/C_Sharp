//случайное от 10 до 99 и показывает наибольшую цифру
Console.Clear();
int num = new Random().Next(10, 100);
Console.WriteLine($"Число {num} ");
int num1 = num /10; //первая цифра
int num2 = num % 10; //вторая цифра
if (num1>num2)
{
    Console.WriteLine($"Цифра {num1}, больше цифры {num2}");
}if(num2>num1)
{
    Console.WriteLine($"Цифра {num2}, больше цифры {num1}"); 
}else{
    Console.WriteLine($"Цифра {num1}, равна цифре {num2}"); 
}