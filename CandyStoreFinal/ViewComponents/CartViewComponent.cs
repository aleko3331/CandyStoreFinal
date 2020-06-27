using CandyStoreFinal.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CandyStoreFinal.ViewComponents
{
    public class CartViewComponent : ViewComponent
    {
        private readonly IItemsService productsService;
        public CartViewComponent(IItemsService _itemsService)
        {
            productsService = _itemsService;
        }

        public async Task<IViewComponentResult> InvokeAsync(int maxPriority, bool isDone)
        {
            var items = productsService.CartCount();
            return View("BadgeCount", items);
        }
    }
}
