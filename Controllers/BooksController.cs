using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BooksApi.Entities;
using BooksApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace BooksApi.Controllers 
{
    [Route("api/books")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private IBooksRepository _repository;


        public BooksController(IBooksRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }


        [HttpGet]
        public async Task<IActionResult> GetBooks() 
        {
            IEnumerable<Book> bookEntities = await _repository.GetBooksAsync();

            return Ok(bookEntities);
        }


        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetBook(Guid id)
        {
            Book bookEntity = await _repository.GetBookAsync(id);

            if (bookEntity == null) 
            {
                return NotFound();
            }

            return Ok(bookEntity);
        }


    }
}