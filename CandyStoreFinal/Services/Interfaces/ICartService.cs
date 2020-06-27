using CandyStoreFinal.Enums;
using CandyStoreFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyStoreFinal.Services.Interfaces
{
    public interface ICartService
    {
        void AddToCart(Item product);
        int ItemsCount();
        int TotalItems();
        IEnumerable<Item> CartItems(int page, int pageSize, SortBy sortby);
    }
}
