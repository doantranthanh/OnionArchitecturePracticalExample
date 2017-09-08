using System.Collections.Generic;
using BookingApp.Domain.Entities;

namespace BookingApp.Web.Ui.Models
{
    public class BookViewModel
    {
        private List<Book> books;

        public BookViewModel()
        {
            this.books = new List<Book>();
        }

        public IList<Book> Books
        {
            get { return books; }
        }
    }
}