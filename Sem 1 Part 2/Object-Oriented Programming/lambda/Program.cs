namespace lambda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action<string> greet = name =>
            {
                string greeting = $"Hello {name}!";
                Console.WriteLine(greeting);
            };
            greet("World");
            // Output:
            // Hello World!
        }
    }
}