//Console.Clear();
Console.WriteLine("Введите a: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите b: ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine($"{a}, {b}");

//if(Math.Pow(b, 2) == a){ Через функцию
if(a == b*b){
    Console.WriteLine("Yes");
}else{
    Console.WriteLine("No");
}    