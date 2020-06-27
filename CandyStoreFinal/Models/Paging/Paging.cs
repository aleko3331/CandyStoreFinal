using CandyStoreFinal.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyStoreFinal.Models.Paging
{
    public class Paging
    {
        public int CurrentPage { get; set; }
        public int TotalCount { get; set; }
        public int PageSize { get; set; }
        public int TotalPages => (int)Math.Ceiling(decimal.Divide(TotalCount, PageSize));

        public SortDirection SortDirection { set; get; }
        public Cart ProductCart { get; set; }
    }
}
