namespace PatternMatching.Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new Person() { Age = 25};

            Console.WriteLine($"Contribution for person: {Contribution(person)}");
            Console.WriteLine($"isTeacher: {IsTeacher(new Teacher())}");

            Console.ReadLine();
        }

        static double Contribution(Person person) => person.Age switch
        {
            > 50 or >= 50 => 25500,
            < 50 and > 18 => 19500,
            _ => 0
        };

        static bool IsTeacher(Person person) => person switch
        {
            not Teacher => false,
            not Student => true,
        };
    }

    class Person
    {
        public int Age { get; set; }
    }

    class Teacher : Person { }
    class Student: Person { }
}