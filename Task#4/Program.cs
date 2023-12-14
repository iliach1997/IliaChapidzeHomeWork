using System.Security.Cryptography.X509Certificates;

namespace Task_4
{
    internal class Program
    {    
        static void Main(string[] args)
        {
            void Print()
            {
                Console.WriteLine("____________________________________Welcome to the library_______________________________________");
                All();
                Console.WriteLine("___________________________You can add a book to take away or return_____________________________");
                Console.WriteLine("------------------Enter the appropriate command from the console add take or return------------- ");
            }
            void Addbook()
            {
                Console.WriteLine("Add book Library");
                Console.WriteLine("Enter book Title:");
                var title = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Enter book author:");
                var author = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Enter book availablecopies:");
                var availablecopies = Convert.ToInt32(Console.ReadLine());
                var book = new Book(title, author, availablecopies);
                var library = new Library();
                library.AddBook(book);
                library.PrintBook();
            }
            void Takebook()
            {
                var library = new Library();
                Console.WriteLine("Enter the name of the book:");
                var name = Console.ReadLine();
                library.BorrowBook(name);
                library.PrintBook();
            }
            void Returnbook()
            {
                var library = new Library();
                Console.WriteLine("Enter the name of the book:");
                var name = Console.ReadLine();
                library.ReturnBook(name);
            }
            void All() 
            { 
                var library = new Library();
                library.PrintBook();
            }
            Print();
            var comand=Convert.ToString(Console.ReadLine());
            if (comand == "add")
            {
                Addbook();
            }
            else if (comand == "take")
            {
                Takebook();
            }
            else if (comand == "return")
            {
                Returnbook();
                All();
            }
            else { All(); }
            Console.ReadKey();
        }
    }
}
