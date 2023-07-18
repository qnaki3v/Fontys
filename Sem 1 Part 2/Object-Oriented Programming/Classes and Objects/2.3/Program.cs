namespace _2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a whole number.");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine($"{num} is even");
            }
            else
            {
                Console.WriteLine($"{num} is odd");
            }
        }
    }
}