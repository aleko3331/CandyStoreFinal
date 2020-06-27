using CandyStoreFinal.Enums;
using CandyStoreFinal.Models;
using CandyStoreFinal.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyStoreFinal.Services.Implementations
{
    public class CartService : ICartService
    {
        private readonly Dictionary<int, Item> items = new Dictionary<int, Item>();

        public void AddToCart(Item item)
        {
            try
            {
                var model = items.Where(x => x.Value.Id == item.Id);
                items[item.Id].Quantity++;
            }
            catch (Exception)
            {
                items.Add(item.Id, item);
            }
        }

        public int ItemsCount()
        {
            return items.Count;
        }

        public int TotalItems()
        {
            return items.Select(x => x.Value.Quantity).Sum();
        }

        public IEnumerable<Item> CartItems(int page, int pageSize, SortBy sortby)
        {
            var propertyInfo = typeof(Item).GetProperty(sortby.ToString());

            return items
                .Select(x => x.Value)
                .OrderBy(product => propertyInfo.GetValue(product))
                .ThenBy(product => product.Id)
                .Skip(page * pageSize)
                .Take(pageSize);
        }
    }
}
