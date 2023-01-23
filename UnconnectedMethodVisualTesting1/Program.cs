namespace UnconnectedMethodVisualTesting1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            NextMultipleOf5(11);

            int testingInt = 11 % 5;
            Console.WriteLine(testingInt);
        }

        public static void NextMultipleOf5(int num)
        {
            int nextMultipleof5 = num + (5 - num % 5);
            Console.WriteLine(nextMultipleof5);
        }

        


    }
}