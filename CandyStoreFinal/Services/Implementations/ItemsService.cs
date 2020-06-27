using CandyStoreFinal.Enums;
using CandyStoreFinal.Models;
using CandyStoreFinal.Models.Paging;
using CandyStoreFinal.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyStoreFinal.Services.Implementations
{
    public class ItemsService : IItemsService
    {
        private readonly IItemsRepository itemsrepository;
        private readonly ICartService cartservice;

        public ItemsService(IItemsRepository _itemsrepository, ICartService _cartservice)
        {
            itemsrepository = _itemsrepository;
            cartservice = _cartservice;
        }

        public IEnumerable<Item> GetItems() => itemsrepository.GetItems();

        public Pagination<IEnumerable<Item>, SortBy> PagedItems(int page, int pageSize, SortBy sortby)
        {
            return new Pagination<IEnumerable<Item>, SortBy>()
            {
                PageSize = pageSize,
                CurrentPage = page,
                TotalCount = itemsrepository.ItemssCount(),
                Data = itemsrepository.FilteredItems(page - 1, pageSize, sortby),
                Sorter = sortby
            };
        }

        public void AddToCart(Item item)
        {
            item.Quantity = 1;
            cartservice.AddToCart(item);
        }

        public int CartCount()
        {
            return cartservice.TotalItems();
        }

        public Pagination<IEnumerable<Item>, SortBy> CartItemss(int page, int pageSize, SortBy sortby)
        {
            return new Pagination<IEnumerable<Item>, SortBy>()
            {
                PageSize = pageSize,
                CurrentPage = page,
                TotalCount = cartservice.TotalItems(),
                Data = cartservice.CartItems(page - 1, pageSize, sortby),
                Sorter = sortby
            };
        }
    }
}
