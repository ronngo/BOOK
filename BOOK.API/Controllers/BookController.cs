using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BOOK.BAL.Interface;
using BOOK.Domian.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BOOK.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookService bookService;

        public BookController(IBookService bookService)
        {
            this.bookService = bookService;
        }
        [HttpGet]
        [Route("/api/Book/gets")]
        public async Task<OkObjectResult> Gets()
        {
            return Ok(await bookService.Gets());
        }

        [HttpPost]
        [Route("/api/Book/create")]
        public async Task<OkObjectResult> Create(CreateBookRequest request)
        {
            return Ok(await bookService.CreateBook(request));
        }

        [HttpPost]
        [Route("/api/Book/update")]
        public async Task<OkObjectResult> Update(UpdateBookRequest request)
        {
            return Ok(await bookService.UpdateBook(request));
        }

        [HttpDelete]
        [Route("/api/Book/Delete")]
        public async Task<OkObjectResult> Delete(DeleteBookRequest request)
        {
            return Ok(await bookService.DeleteBook(request));
        }
    }
}
