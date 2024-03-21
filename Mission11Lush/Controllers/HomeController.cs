using Microsoft.AspNetCore.Mvc;
using Mission11Lush.Models;
using System.Diagnostics;
using Mission11Lush.Models.ViewModels;

namespace Mission11Lush.Controllers
{
    public class HomeController : Controller
    {
        private IBookRepository _repo;
        public HomeController(IBookRepository temp)
        {
            _repo = temp;
        }

        public IActionResult Index(int pageNum)
        {
            int pageSize = 5;

            var blah = new ProjectListViewModel
            {
                Books = _repo.Books
                .OrderBy(x => x.Title)
                .Skip((pageNum - 1) * pageSize)
                .Take(pageSize),

                PaginationInfo = new PaginationInfo
                {
                    CurrentPage = pageNum,
                    ItemsPerPage = pageSize,
                    TotalItems = _repo.Books.Count()
                }
            };
            return View(blah);
        }
    }
}
