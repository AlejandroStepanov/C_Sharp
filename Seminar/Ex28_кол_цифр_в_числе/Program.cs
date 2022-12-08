// Количество цифр в числе
Console.Clear();
Console.WriteLine("Enter the number: ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine($"Кол-во цифр {CNT(N)}");


int CNT (int number)
{
    int count = 0;
        for(int i = number; i > 0; count++)
        {
        i/=10;
        }
        
    
    return count;
}

// int Count =  N.ToString().Length;
// Console.WriteLine($"Кол-во цифр {Count}");