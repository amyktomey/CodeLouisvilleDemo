namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("My name is Amy, and I can copunt to ten. Watch!!");

            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(i);
                    Thread.Sleep(1000);
                }
            }
            Console.WriteLine("Ta-DAH!");
        }
    }
}