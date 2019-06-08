using System;

namespace getSet
{
    class Person
    {
        private string name = "Roneet";
        private int age = 22;

        // access private fields using getter, setter
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }

        // access private fields using methods
        public void print(string name, int age)
        {
            this.name = name;
            this.age = age;
            System.Console.WriteLine(this.name);
            System.Console.WriteLine(this.age);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {

            Person person = new Person();

            person.print("Vinay", 100);

            person.Name = "Roop";
            person.Age = 200;

            Console.WriteLine(person.Name);
            Console.WriteLine(person.Age);

        }
    }
}
