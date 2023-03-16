using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore_anorto.Models
{
    // Bookstore Repository Interface. Won't be instantiated but can have child classes (like EFBookstoreRepository).
    public interface IBookstoreRepository
    {
        IQueryable<Book> Books { get; }
    }
}
