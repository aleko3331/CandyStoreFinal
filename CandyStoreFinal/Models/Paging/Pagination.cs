using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyStoreFinal.Models.Paging
{
    public class Pagination<T, T1> : Paging
    {
        public T Data { get; set; }
        public T1 Sorter { get; set; }

    }
}
