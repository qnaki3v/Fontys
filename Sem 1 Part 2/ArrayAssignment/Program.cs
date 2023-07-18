namespace ArrayAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input number of users");
            int count = int.Parse(Console.ReadLine());
            Person[] people = new Person[count];

            for (int i = 0; i < people.Length; i++)
            {
                Console.WriteLine("Please input name");
                string name = Console.ReadLine();
                Console.WriteLine("Please input age");
                int age = int.Parse(Console.ReadLine());
                Person person = new Person(name, age);
                people[i] = person;
            }
            foreach (Person p in people)
            {
                Console.WriteLine(p);
            }
        }
    }
}