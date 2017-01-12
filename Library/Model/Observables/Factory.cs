using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Model.Factory;

namespace Library.Model.Observables
{
    class Factory : IAbstractFactory
    {
        public Factory( IAbstractFactory aFactory )
        {
            BaseFactory = aFactory;
        }

        public IAbstractFactory BaseFactory { get; }

        public IBook CreateBook()
        {
            return new ObservableBook( BaseFactory.CreateBook() );
        }

        public IBookItem CreateBookItem( IBook aBook = null )
        {
            return BaseFactory.CreateBookItem( aBook );
        }

        public IAuthor CreateAuthor()
        {
            return BaseFactory.CreateAuthor();
        }
    }
}
