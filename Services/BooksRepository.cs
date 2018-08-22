using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BooksApi.Contexts;
using BooksApi.Entities;

namespace BooksApi.Services
{
    public class BooksRepository : IBooksRepository, IDisposable
    {
        private BooksContext _context;

        public BooksRepository(BooksContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        IEnumerable<Book> IBooksRepository.GetBooks()
        {
            throw new NotImplementedException();
        }

        Book IBooksRepository.GetBook(Guid id)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<Book>> IBooksRepository.GetBooksAsync()
        {
            throw new NotImplementedException();
        }

        Task<Book> IBooksRepository.GetBookAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            Dispose(true);

            // Let the garbage collection know our repo has already
            // been cleaned, as the context has been disposed.
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing) 
        {
            if (disposing) 
            {
                if (_context != null) 
                {
                    _context.Dispose();
                    _context = null;
                }
            }
        }
    }
}