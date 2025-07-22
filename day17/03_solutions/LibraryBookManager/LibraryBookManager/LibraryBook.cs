using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBookManager
{
    internal class LibraryBook
    {
        public string title;
        public string author;
        private bool isAvailable;

        public LibraryBook(string bookTitle, string bookAuthor)
        {
            title = bookTitle;
            author = bookAuthor;
            isAvailable = true;
        }

        public void BorrowBook() 
        {
            /* TODO */
            if (isAvailable)
            {
                isAvailable = false;
                Console.WriteLine($"{title} has been borrowed.");
            }
            else
            {
                Console.WriteLine($"{title} is currently not available.");
            }
        }
        public void ReturnBook()
        {
            /* TODO */
            isAvailable = true;
            Console.WriteLine($"{title} has been returned.");


        }

        public void GetStatus()
        {
            /* TODO */
            Console.WriteLine($"{title} by {author} is " + ( isAvailable ? "avaialable": "not available" ));

        }

    }
}
