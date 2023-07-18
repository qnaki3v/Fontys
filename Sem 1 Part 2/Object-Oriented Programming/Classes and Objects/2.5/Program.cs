namespace _2._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please input a number or $:");
            string input = Console.ReadLine();
            List<int> nums= new List<int>();
            while (input != "$")
            {
                Console.Write("Please input a number or $:");
                nums.Add(int.Parse(input));

                input = Console.ReadLine();
            }
            Console.WriteLine("The average is " + nums.Average());
            Console.WriteLine("The highest is " + nums.Max());
            Console.WriteLine("The lowest is " + nums.Min());
            Console.WriteLine("The sum is " + nums.Sum());
            int multiplication = nums[0];

            for (int i = 1; i < nums.Count; i++)
            {
                multiplication *= nums[i];
            }
            Console.WriteLine("The multiplication of all number is " + multiplication);
        }
    }
}