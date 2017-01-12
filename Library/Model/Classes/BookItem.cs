using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Library.Model.Classes
{
    class BookItem : IBookItem
    {
        public BookItem( IBook aBook = null )
        {
            Book = aBook;
        }

        public string Barcode { get; set; }

        public IBook Book { get; set; }
    }
}
