using System.Web.Mvc;
using BookingApp.Web.Ui.Controllers;
using BookingApp.Web.Ui.Models;
using FluentAssertions;
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
    }
}
