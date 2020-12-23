using System;
using System.Collections.Generic;
using System.Text;

namespace BOOK.Domian.Response
{
   public class UpdateBookResult
    {
        public int BookId { get; set; }

        public string Result { get; set; }

        public string Message { get; set; }
    }
}
