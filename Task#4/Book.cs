using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class Book
    {
       public string Title { get; set; }
       public string Author { get; set; }
       public int AvailableCopies { get; set; }
       public Book(string title,string author, int availablecopies) { 
            Title = title;
            Author = author;
            AvailableCopies = availablecopies;
       }

       public Book()
       {
       }
    }
}
