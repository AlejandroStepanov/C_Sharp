// Вводим 2 чиста и проверяем является ли второе кратным первому
Console.Clear();
Console.WriteLine("Введите первое число: ");
int n1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int n2 = int.Parse(Console.ReadLine());
if(n1 % n2 == 0)
{
    Console.WriteLine($"Число {n2} кратно {n1}");
}else{
    Console.WriteLine($"Остаток = {n1 % n2} ");
}

//принимает число. Определить является ли кратным 7 и 23.
//14, 46, 161

Console.WriteLine("Введите первое число: ");
int a1 = int.Parse(Console.ReadLine());

int a2 = 7;
int a3 = 23;

if(a1%a2 == 0 && a1%a3 == 0)
{
    Console.WriteLine("кратно");
}else{
    Console.WriteLine("не кратно");
}
    