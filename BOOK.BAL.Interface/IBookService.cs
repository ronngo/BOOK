﻿using BOOK.Domian.Request;
using BOOK.Domian.Response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BOOK.BAL.Interface
{
   public interface IBookService
    {
        Task<IEnumerable<Book>> Gets();

        Task<CreateBookResult> CreateBook(CreateBookRequest request);

        Task<UpdateBookResult> UpdateBook(UpdateBookRequest request);

        Task<DeleteBookResult> DeleteBook(DeleteBookRequest request);
    }
}
