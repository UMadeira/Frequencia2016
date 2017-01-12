using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Model.Factory
{
    interface IAbstractFactory
    {
        IBook     CreateBook();
        IBookItem CreateBookItem( IBook aBook = null );
        IAuthor   CreateAuthor();
    }
}
