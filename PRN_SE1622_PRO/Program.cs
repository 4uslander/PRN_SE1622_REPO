namespace fptedu.se1622;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine($"Hello world");
        //int a = 5, b = 6;
        Console.WriteLine($"input a and b: ");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int name;
        var salary = 100.5;
        Console.WriteLine(salary.GetType().Name);


        dynamic age = 20;//int32
        age = true;//bool

        Console.WriteLine($"Total of a = {a} and b = {b} is: {Sum(a,b)}");

        Console.ReadLine();
    }
    public static int Sum(int a, int b)
    {
        return a + b;
    }
}