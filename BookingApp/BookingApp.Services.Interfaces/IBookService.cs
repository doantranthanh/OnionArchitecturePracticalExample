using System.Collections.Generic;
using BookingApp.Domain.Entities;

namespace BookingApp.Services.Interfaces
{
    public interface IBookService
    {
        IEnumerable<Book> GetAllBooks();
    }
}
