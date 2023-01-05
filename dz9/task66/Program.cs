Console.Clear();
Console.WriteLine("введите m число");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("введите n число");
int n = int.Parse(Console.ReadLine());
Console.Write($"Сумма чисел в этом диапазоне : {naturalnumbers(m,n)}");
int naturalnumbers(int m, int n)
{
    if(m == n)
    {
        Console.WriteLine("Конец");
        return n;
    }
    int summ = m  + naturalnumbers(m + 1 , n);
    return summ;
}