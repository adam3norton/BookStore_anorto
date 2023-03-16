using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore_anorto.Models
{
    // This is what will allow info to get passed around the app
    public class EFBookstoreRepository : IBookstoreRepository
    {
        private BookstoreContext context { get; set; }

        public EFBookstoreRepository(BookstoreContext bsc) => context = bsc;

        public IQueryable<Book> Books => context.Books;
    }
}
