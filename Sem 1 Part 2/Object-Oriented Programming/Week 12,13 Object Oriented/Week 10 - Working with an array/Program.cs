namespace Week_10___Working_with_an_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please input the amount of people:");
            int peopleCount = int.Parse(Console.ReadLine());
            Console.WriteLine("----------------------------");

            Person[] people = new Person[peopleCount];
            for (int i = 0; i < peopleCount; i++)
            {
                Console.Write($"Please input the name for person {i + 1}:");
                string currName = Console.ReadLine();
                Console.Write($"Please input the age for person {i + 1}:");
                int currAge = int.Parse(Console.ReadLine());
                people[i] = new Person(currName, currAge);
            }
            Console.WriteLine("----------------------------");

            Console.WriteLine("You have inputted the following data:");
            foreach (var person in people)
            {
                Console.WriteLine($"{person.Name} ({person.Age} year(s) old)");
            }
        }
    }
}