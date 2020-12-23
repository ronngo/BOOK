using BOOK.BAL.Interface;
using BOOK.DAL.Interface;
using BOOK.Domian.Request;
using BOOK.Domian.Response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BOOK.BAL
{

    public class BookService : IBookService
    {
        private readonly IBookRepository bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            this.bookRepository = bookRepository;
        }

        public async Task<CreateBookResult> CreateBook(CreateBookRequest request)
        {
            return await bookRepository.CreateBook(request);
        }

        public async Task<DeleteBookResult> DeleteBook(DeleteBookRequest request)
        {
            return await bookRepository.DeleteBook(request);
        }

        public async Task<IEnumerable<Book>> Gets()
        {
            return await bookRepository.Gets();
        }

        public async Task<UpdateBookResult> UpdateBook(UpdateBookRequest request)
        {
            return await bookRepository.UpdateBook(request);
        }
    }
}
