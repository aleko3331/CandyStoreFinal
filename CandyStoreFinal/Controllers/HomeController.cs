using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CandyStoreFinal.Models;
using CandyStoreFinal.Services.Interfaces;
using CandyStoreFinal.Enums;

namespace CandyStoreFinal.Controllers
{
    public class HomeController : Controller
    {

        private readonly IItemsService itemsService;

        public HomeController(ILogger<HomeController> logger, IItemsService _itemsService)
        {
            itemsService = _itemsService;
        }

        public IActionResult Index(int currentPage = 1, int pageSize = 3, SortBy sortby = SortBy.Price)
        {
            var paging = itemsService.PagedItems(currentPage, pageSize, sortby);
            return View(paging);
        }

        [HttpPost]
        public IActionResult AddToCart(Item product)
        {
            itemsService.AddToCart(product);
            return RedirectToAction("Index");
        }

    }
}
