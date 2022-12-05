//случайное от 100 до 999 (1000) и показывает наибольшую цифру
Console.Clear();
int num = new Random().Next(100, 1000);
Console.WriteLine($"Число {num} ");

//int num1 = num / 100; //первая цифра
//int num2 = num % 100; //вторая цифра
//int num3 = num % 10; //третья цифра
//Console.WriteLine($"{num1}{num3}");

num = (num/100)*10 + num % 10;//математически
Console.WriteLine(num);

