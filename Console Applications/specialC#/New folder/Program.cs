using System;

namespace New_folder
{

    class Book
    {
        private Int16 id;
        private String name;
        public string Name { get => name; set => name = value; }
        public short Id { get => id; set => id = value; }
        public Book() { }
        public Book(Int16 id, String name)
        {
            if (id > 0)
            {
                this.Id = id;
                this.Name = name;
                System.Console.WriteLine("Book ID : " + this.Id);
                System.Console.WriteLine("Book Name : " + this.Name);
            }
            else
            {
                System.Console.WriteLine("Enter ID Greater than 0");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book(1, "Harry Poter");
            Console.Read();
        }
    }
}

