// //Вид 1 не возвращают, не принимают.
void Method1() 
{
    Console.WriteLine("Автор ...");
}

// Method1(); // вывод метода

//Вид 2. Не возвр, могут принимать.
void Method2(string msg)
{
    Console.WriteLine(msg);
}
// Method2("New method");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
// Method21("Hello", 5); // Вывод
// Method21(count: 4, msg:"Gute");//если именованный аргумент, можно в любом порядке

// Вид 3. Что-то возвращ. Не принимает. Тип данных - указать.
int Method3()
{
    return DateTime.Now.Year;
}
// int year = Method3();//присвоение
// Console.WriteLine(year);//использование

// Вид 4. Принимает -> возвращает
string Method4(int count, string text)
{
    int i =0;
    string result = String.Empty; //присвоение пустой строки. Можно: "";

    while(i<count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(5, "Y "); // присвоение
// Console.WriteLine(res); //Вывод

// FOR. Цикл со счетчиком.
string MethodFor(int count, string text)
{
    string result = String.Empty; //присвоение пустой строки. Можно: "";

    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string X = MethodFor(7, "X "); // присвоение
// Console.WriteLin e(X); //Вывод

for(int i = 2; i<10; i++)
{
    for (int j = 2; j<10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i*j}");
    }
    Console.WriteLine();
}