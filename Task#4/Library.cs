using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class Library
    {
        public List<Book> books = new List<Book>()
        {
        new Book()
        {
            Title = "War and Peace",
            Author = "Lev Tolstoy",
            AvailableCopies = 7
        },
        new Book()
        {
            Title = "The Fraud",
            Author = "Zadie Smith",
            AvailableCopies = 12
        },
        new Book()
        {
            Title = "North Woods",
            Author = "Daniel Mason",
            AvailableCopies = 9
        },
        new Book()
        {
            Title = "The Bee Sting",
            Author = "Paul Murray",
            AvailableCopies = 2
        }, };
        public void AddBook(Book book)
        {   
            books.Add(book);
            Console.WriteLine("The book has been successfully added :)");
        }
        public void BorrowBook(string name)
        {
            for (int i = 0; i < books.Count; i++)
            {
               if (books[i].Title == name)
               {
                    Console.WriteLine($"Find Author:{books[i].Author} Title:{books[i].Title} " +
                    $"AvailableCopies:{books[i].AvailableCopies}");
                    Console.WriteLine("Taking out the book yes");
                    var comand=Convert.ToString(Console.ReadLine());
                    if (comand=="yes" &&books[i].AvailableCopies>0)
                    {   
                        books[i].AvailableCopies--;
                        Console.WriteLine($" Author:{books[i].Author} Title:{books[i].Title} " +
                        $"AvailableCopies: 1 ");
                        Console.WriteLine("You can take out the book:)");
                    }
                    else
                    {
                        Console.WriteLine("Quantity is limited:(");
                    }
               }else { Console.WriteLine("Not found in the library!!!"); }
            }
        }
        public void ReturnBook(string name)
        {
            for(int i = 0;i < books.Count;i++)
            {
               if( books[i].Title == name)
                {
                    Console.WriteLine("Would you like to return the book? Entere Yes");
                    if(Console.ReadLine() == "yes")
                    {
                        books[i].AvailableCopies= books[i].AvailableCopies+1;
                        Console.WriteLine($" Author:{books[i].Author} Title:{books[i].Title} " +
                        $"AvailableCopies:{books[i].AvailableCopies}");
                        Console.WriteLine("The book is returned:)");
                    }
                    else { Console.WriteLine("Please enter the book name correctly:("); }
                } 
          
            }
        }
        public void PrintBook()
        {   var count = 0;
            foreach (var book in books)
            {
                count++;
                Console.WriteLine($"({count}) Title:{book.Title} Author:{book.Author} AvailableCopies:{book.AvailableCopies}");
            }
        }
    }
}
