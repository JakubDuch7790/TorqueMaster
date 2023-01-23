namespace Test;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        NextMultipleOf5(11);
    }


    public static void NextMultipleOf5(int num)
    {
        int nextMultipleof5 = num + (5 - num % 5);
        Console.WriteLine(nextMultipleof5);
    }
}