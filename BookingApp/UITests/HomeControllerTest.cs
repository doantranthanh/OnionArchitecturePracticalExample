using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using BookingApp.Domain.Entities;
using BookingApp.Services.Interfaces;
using BookingApp.Web.Ui.Controllers;
using BookingApp.Web.Ui.Models;
using FluentAssertions;
using Moq;
using Ploeh.AutoFixture;
using Xunit;

namespace UITests
{
    public class HomeControllerTest
    {
        [Fact]
        public void IndexWillReturnViewWithCorrectModel()
        {
            var fixture = new Fixture().Customize(new BookAppWebCustomization());
            var sut = fixture.Create<HomeController>();

            var result = sut.Index() as ViewResult;

            result.ViewData.Model.Should().BeOfType<BookViewModel>();
        }

        [Fact]
        public void IndexWillReturnViewModelWithCorrectBooks()
        {
            var fixture = new Fixture().Customize(new BookAppWebCustomization());
            var books = fixture.CreateMany<Book>().ToList();

            fixture.Register(() =>
            {
                var serviceStub = new Mock<IBookService>();
                serviceStub.Setup(s => s.GetAllBooks()).Returns(books);
                return serviceStub.Object;
            });

            var sut = fixture.Create<HomeController>();

            var viewResult = sut.Index() as ViewResult;
            var result = ((BookViewModel)viewResult.Model).Books.ToList();

            result.ShouldBeEquivalentTo(books);

        }
    }
}
