// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
NextMultipleOf5(11);



public class Class1
{
    public static void NextMultipleOf5(int num)
    {
        int nextMultipleof5 = num + (5 - num % 5);
        Console.WriteLine(nextMultipleof5);
    }
}
