Console.Write("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());

int akkermanFunction(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) {
        return akkermanFunction(m - 1, 1);
    }
    else 
    {
        return akkermanFunction( m - 1 , akkermanFunction(m, n - 1));
    }
}

Console.Write($"Число по функции Аккермана =  {akkermanFunction(m, n)} ");