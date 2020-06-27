using CandyStoreFinal.Enums;
using CandyStoreFinal.Models;
using CandyStoreFinal.Models.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyStoreFinal.Services.Interfaces
{
    public interface IItemsService
    {
        void AddToCart(Item product);
        int CartCount();
        Pagination<IEnumerable<Item>, SortBy> CartItemss(int page, int pageSize, SortBy sortby);
        IEnumerable<Item> GetItems();
        Pagination<IEnumerable<Item>, SortBy> PagedItems(int page, int pageSize, SortBy sortby);
    }
}
