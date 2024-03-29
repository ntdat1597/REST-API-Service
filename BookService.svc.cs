﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace RESTvsWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "BookService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select BookService.svc or BookService.svc.cs at the Solution Explorer and start debugging.
    public class BookService : IBookService
    {
        static IBookRepository repository = new BookRepository();
        public string AddBook(Book book)
        {
            Book newBook = repository.AddNewBook(book);
            return "id = " + newBook.BookID;
        }

        public Book GetBookByID(string id)
        {
            return repository.GetBookByID(int.Parse(id));

        }

        public List<Book> GetBooksList()
        {
            return repository.GetAllBook();
        }
    }
}
