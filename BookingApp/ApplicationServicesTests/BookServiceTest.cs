using System;
using System.Collections.Generic;
using System.Linq;
using BookingApp.Domain.Entities;
using BookingApp.Domain.Interfaces;
using BookingApp.Web.Ui.Services;
using FluentAssertions;
using Moq;
using Xunit;
using Ploeh.AutoFixture;

namespace ApplicationServicesTests
{
    public class BookServiceTest
    {
        [Fact]
        public void CreateWithNullRepositoryWillThrow()
        {
            var fixture = new ApplicationServiceFixture();
            IBookRepository nullRepository = null;

            Assert.Throws<ArgumentNullException>(() =>
                            fixture.Build<BookService>()
                                .FromFactory(() => new BookService(nullRepository))
                                .Create());
        }

        [Fact]
        public void GetAllBooksWillReturnCorrectListOfBook()
        {
            var fixture = new ApplicationServiceFixture();
            var listOfBook = new List<Book>()
            {
                fixture.Create<Book>(),
                fixture.Create<Book>(),
                fixture.Create<Book>(),
                fixture.Create<Book>(),
                fixture.Create<Book>(),
            };

            var repositoryStub = new Mock<IBookRepository>();
            repositoryStub.Setup(b => b.GetAllBook()).Returns(listOfBook);
            var sut = new BookService(repositoryStub.Object);

            var books = sut.GetAllBooks();

            books.ToList().Count.Should().Be(listOfBook.Count);
        }
    }
}
