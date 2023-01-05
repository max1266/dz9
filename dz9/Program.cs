Console.Clear();
Console.WriteLine("введите m число");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("введите n число");
int n = int.Parse(Console.ReadLine());
Console.Write(naturalnumbers(m,n));
string naturalnumbers(int m, int n)
{
    if(n==m)
    {
       Console.WriteLine(n);
        return n.ToString();
    }
    string s = naturalnumbers(m + 1, n) + " " + m.ToString();
    return(s);
}