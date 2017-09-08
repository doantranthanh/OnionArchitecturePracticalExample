using System.Collections.Generic;
using BookingApp.Domain.Entities;

namespace BookingApp.Domain.Interfaces
{
    public interface IBookRepository
    {
        IEnumerable<Book> GetAllBook();
    }
}
