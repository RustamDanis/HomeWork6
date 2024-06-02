class Program
{
static void Main(string[] args)
{
    Console.WriteLine("Введите число М: ");
    int M = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число N: ");
    int N = Convert.ToInt32(Console.ReadLine());
    PrintNumInrange(M, N);
}

static void PrintNumInrange(int start, int end)
{
    if(start <= end)    
    {
        Console.Write(start);
        if (start < end)
        Console.Write(", ");
        PrintNumInrange(start + 1, end);
        
    }
}
}