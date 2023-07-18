namespace _2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Supply a base number.");
            int baseNum = int.Parse(Console.ReadLine());
            Console.WriteLine("How many multiplications to show?");
            int multiplications = int.Parse(Console.ReadLine());

            for (int i = 0; i < multiplications; i++)
            {
                Console.WriteLine($"{i + 1} x {baseNum} = {(i + 1) * baseNum}");
            }
        }
    }
}