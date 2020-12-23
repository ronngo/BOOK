using System;
using System.Collections.Generic;
using System.Text;

namespace BOOK.Domian.Request
{
   public class CreateBookRequest
    {

       
        public string NameBook { get; set; }
        public string NameAuthor { get; set; }
        public string Description { get; set; }
        public string Date { get; set; }
        public int Amount { get; set; }
    }
}
