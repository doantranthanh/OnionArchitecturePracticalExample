using System;
using System.Collections.Generic;
using BookingApp.Domain.Entities;
using BookingApp.Domain.Interfaces;
using BookingApp.Services.Interfaces;

namespace BookingApp.Web.Ui.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository bookRep;

        public BookService(IBookRepository bookRep)
        {
            if (bookRep == null)
            {
                throw new ArgumentNullException(nameof(bookRep));
            }
            this.bookRep = bookRep;
        }
        public IEnumerable<Book> GetAllBooks()
        {
            return bookRep.GetAllBook();
        }
    }
}