using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BooksApi.Entities;

namespace BooksApi.Services
{
    public interface IBooksRepository
    {
        IEnumerable<Book> GetBooks();

        Book GetBook(Guid id);

        Task<IEnumerable<Book>> GetBooksAsync();

        Task<Book> GetBookAsync(Guid id);
    }
}
