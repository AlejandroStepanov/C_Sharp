//Факториал

// Console.Clear();
// int Factorial(int n)
// {
//     if(n==1) return 1;
//     else return n*Factorial(n-1);
// }

// for (int i =1; i <17; i++)
// {
//     Console.WriteLine($"{i}! = Factorial(i)");
// }


//Фибоначи

int Fibonachi(int n)
{
    if(n==1 || n==2) return 1;
    else return Fibonachi (n-1) + Fibonachi (n-2);
    
}

for (int i =1; i <5; i++)
{
    Console.WriteLine($"{Fibonachi(i)}");

}
