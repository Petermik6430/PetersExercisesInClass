using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTDWorkshop.ClassLibrary
{
    public class BookCollection
    {
        private List<Book> _books = new();

        public void Add(Book book)
        {
            _books.Add(book);
        }

        public Book FindByIsbn(string bookIsbn)
        {
            return _books.FirstOrDefault(book => book.ISBN == bookIsbn);
        }
    }
}
