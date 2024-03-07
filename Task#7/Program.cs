namespace Task_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
          var citizens = new List<Person>()
            {
                new Person() { Name = "Ilia", Age = 26, City = "Foti" },
                new Person() { Name = "Mari", Age = 19, City = "Tbilisi" },
                new Person() { Name = "Giorgi", Age = 46, City = "Gori" },
                new Person() { Name = "Nika", Age = 11, City = "Batumi" },
                new Person() { Name = "Eka", Age = 23, City = "Qutaisi" },
                new Person() { Name = "Elene", Age = 32, City = "Mcxeta" }
            };
          var a = citizens.Where(person => person.Age > 25);
            foreach (var person in a)
            {
                Console.WriteLine($"Age < 25 {person.Age}");
            }
          var b = citizens.OrderByDescending(person => person.Age);
            foreach (var person in b)
            {
                Console.WriteLine($"klebis mixedvit:{person.Age}");
            }
          var c=citizens.Select(person => person);
            foreach (var person in c)
            {
                Console.WriteLine($"tbiliselivar brat:{person.Name}");
            }
        }
        
    }
}
