using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace RESTvsWCF
{
    [DataContract]
    public class Book
    {
        [DataMember]
        public int BookID { get; set; }
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public string ISBN { get; set; }
    }

    public interface IBookRepository
    {
        List<Book> GetAllBook();
        Book GetBookByID(int id);
        Book AddNewBook(Book item);
        bool DeteteBook(int id);
        bool UpdateBook(Book item);

    }

    public class BookRepository : IBookRepository
    {
        private List<Book> books = new List<Book>();
        private int counter = 1;

        public BookRepository()
        {
            AddNewBook(new Book() { Title = "C# programing", ISBN = "123456789 " });
            AddNewBook(new Book() { Title = "Java programing", ISBN = "123456789 " });
            AddNewBook(new Book() { Title = "PHP programing", ISBN = "123456789 " });
            AddNewBook(new Book() { Title = "Python programing", ISBN = "123456789 " });
            AddNewBook(new Book() { Title = "Scala programing", ISBN = "123456789 " });
        }

        public Book AddNewBook(Book item)
        {
            if (item == null)
            {
                throw new ArgumentException("No agrument");
            }
            item.BookID = counter++;
            books.Add(item);
            return item;
            //throw new NotImplementedException();
        }

        public bool DeteteBook(int id)
        {
            int idx = books.FindIndex(b => b.BookID == id);
            if (idx == -1)
            {
                return false;
            }
            books.RemoveAll(b => b.BookID == id);
            return true;
            //throw new NotImplementedException();
        }

        public List<Book> GetAllBook()
        {
            return books;
            //throw new NotImplementedException();
        }

        public Book GetBookByID(int id)
        {

            return books.Find(b => b.BookID == id);
            //throw new NotImplementedException();
        }

        public bool UpdateBook(Book item)
        {
            throw new NotImplementedException();
        }
    }
}