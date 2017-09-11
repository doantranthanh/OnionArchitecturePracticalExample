using System;
using System.Collections.Generic;
using System.Web.Mvc;
using BookingApp.Services.Interfaces;
using BookingApp.Web.Ui.Models;

namespace BookingApp.Web.Ui.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBookService bookService;

        public HomeController(IBookService bookService)
        {
            if (bookService == null)
            {
                throw new ArgumentNullException(nameof(bookService));
            }
            this.bookService = bookService;
        }

        public ActionResult Index()
        {
            var vm = new BookViewModel();

            var books = bookService.GetAllBooks();

            foreach (var book in books)
            {
                vm.Books.Add(book);
            }

            return View(vm);
        }
    }
}