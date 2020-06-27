using CandyStoreFinal.Enums;
using CandyStoreFinal.Models;
using CandyStoreFinal.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyStoreFinal.Services.Implementations
{
    public class ItemRepository : IItemsRepository
    {
        private readonly List<Item> item;

        public ItemRepository()
        {
            item = Data();
        }

        public IEnumerable<Item> GetItems()
        {
            return item;
        }

        public int ItemssCount()
        {
            return item.Count;
        }

        public IEnumerable<Item> FilteredItems(int page, int pageSize, SortBy sort)
        {
            var propertyInfo = typeof(Item).GetProperty(sort.ToString());

            return item
                .OrderBy(product => propertyInfo.GetValue(product))
                .ThenBy(product => product.Id)
                .Skip(page * pageSize)
                .Take(pageSize);
        }

        private List<Item> Data() => new List<Item>()
        {
            new Item{Name = "ჟელატინით", Condition = ItemCondition.ტკბილი.ToString(), Price = 20, PhotoUrl = "https://aprettylifeinthesuburbs.com/wp-content/uploads/2018/11/Easy-Christmas-Gumdrop-Nougat-Candy-150x150.jpg"},
            new Item{Name = "შოკოლადიანი", Condition = ItemCondition.ძალიან_ტკბილი.ToString(), Price = 12, PhotoUrl = "https://i.pinimg.com/474x/20/0b/57/200b57e6032a29f0d6e32925caf9ac35--sweets-clipart-candy-wrappers.jpg"},
            new Item{Name = "ხილის", Condition = ItemCondition.ექსტრა_ტკბილი.ToString(), Price = 30, PhotoUrl = "https://americanprofile.com/wp-content/uploads/2013/10/halloween-candy-classics-150x150.jpg"},
            new Item{Name = "მარციპანი", Condition = ItemCondition.ტკბილი.ToString(), Price = 25, PhotoUrl = "https://www.speldome.com/wp-content/uploads/2019/04/Mahjongg-Dimensions-Candy-150x150.jpg"},
            new Item{Name = "საწუწნი", Condition = ItemCondition.ულტრა_ტკბილი.ToString(), Price = 10, PhotoUrl = "https://aprettylifeinthesuburbs.com/wp-content/uploads/2011/12/Candy-Cane-Crumble-Nutella-Cookies-150x150.jpg"},
            new Item{Name = "ხილის", Condition = ItemCondition.ტკბილი.ToString(), Price = 5, PhotoUrl = "https://boulderlocavore.com/wp-content/uploads/2014/12/Candy-Cane-Hot-Cocoa-Pops-BoulderLocavore.com-205ps-150x150.jpg"},
            new Item{Name = "საღეჭი", Condition = ItemCondition.ექსტრა_ტკბილი.ToString(), Price = 25, PhotoUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcTqpLEcv7QXNGLDDrIdymObkvNaaPx6OTY08L9ITOGiRqm5YOpK&usqp=CAU"},
            new Item{Name = "ვანილით", Condition = ItemCondition.ტკბილი.ToString(), Price = 15, PhotoUrl = "https://wpcdn.us-east-1.vip.tn-cloud.net/www.channel3000.com/content/uploads/2019/12/modern-candy-company-pate-de-fruit-cbd-candy_1556743003799-jpg_38255181_ver1-0-150x150.jpg"},
            new Item{Name = "სამარხვო", Condition = ItemCondition.ულტრა_ტკბილი.ToString(), Price = 36, PhotoUrl = "https://www.sweetestmenu.com/wp-content/uploads/2019/10/caramelcandy19a-150x150.jpg"}

        };
    }
}
