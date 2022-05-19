Main();
static void Main()
{
    

    int x =1, y = 2;
    void Showvalue(int a)
    {
        Console.WriteLine($"x = {x}, a={a}");
        x = 10;
    }
    Showvalue(11);
    Console.WriteLine(x);
}