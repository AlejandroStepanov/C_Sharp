Console.Clear();
Console.WriteLine("Введите a: ");
int a = int.Parse(Console.ReadLine());
int max = a; //если введено несколько одинаковых чисел
Console.WriteLine("Введите b: ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите c: ");
int c = int.Parse(Console.ReadLine());
int count = 1; //счётчик одинаковых значений

if(b>a && b>c)
{max = b;}
if(b==a)
{count+=1;}
if(c>a && c>b)
{max = c;}
if(c==a||c==b)
{count+=1;}
    Console.WriteLine($"Max = {max}");
    Console.WriteLine($"Count of Max = {count}");

    

    
