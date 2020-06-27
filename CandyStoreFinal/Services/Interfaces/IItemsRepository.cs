using CandyStoreFinal.Enums;
using CandyStoreFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyStoreFinal.Services.Interfaces
{
    public interface IItemsRepository
    {
        IEnumerable<Item> GetItems();
        IEnumerable<Item> FilteredItems(int page, int pageSize, SortBy sort);
        int ItemssCount();
    }
}
