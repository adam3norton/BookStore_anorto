using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore_anorto.Models.ViewModels
{
    // Passed to view
    public class PageInfo
    {
        public int BookTotal { get; set; }
        public int BooksPerPage { get; set; }
        public int CurrentPage { get; set; }

        public int TotalPages => (int)Math.Ceiling((double)BookTotal / BooksPerPage);
    }
}
