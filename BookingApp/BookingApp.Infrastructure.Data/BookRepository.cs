using System;
using System.Collections.Generic;
using BookingApp.Domain.Entities;
using BookingApp.Domain.Interfaces;

namespace BookingApp.Infrastructure.Data
{
    public class BookRepository : IBookRepository
    {
        public BookRepository()
        {

        }

        public IEnumerable<Book> GetAllBook()
        {
            return new List<Book>()
            {
                new Book()
                {
                    Author = "A",
                    Title = "A",
                    Price = 12.0d,
                    PublishedYear = 2017,
                },
                new Book()
                {
                    Author = "B",
                    Title = "B",
                    Price = 12.0d,
                    PublishedYear = 2017,
                }, new Book()
                {
                    Author = "C",
                    Title = "C",
                    Price = 12.0d,
                    PublishedYear = 2017,
                }
                , new Book()
                {
                    Author = "D",
                    Title = "D",
                    Price = 12.0d,
                    PublishedYear = 2017,
                }
            };
        }
    }
}
