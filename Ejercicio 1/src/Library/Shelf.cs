using System.Collections.Generic;

namespace SRP
{
    public class Shelf
    {
        private List<Book> books = new List<Book>();
        private int shelfNumber;
    }

    public void ShelveBook(Book book)
    {
        books.Add(book);
    }
}