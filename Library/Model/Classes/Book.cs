using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Model.Classes
{
    class Book : IBook
    {
        private readonly IList<IAuthor>   mAuthors = new List<IAuthor>();
        private readonly IList<IBookItem> mItems   = new List<IBookItem>();

        public string ISBN { get; }
        public string Title { get; set; }
        public string Summary { get; set; }

        public IEnumerable<IAuthor> Authors => mAuthors;

        public void Append( IAuthor aAuthor )
        {
            if ( mAuthors.Contains(aAuthor) ) return;
            mAuthors.Add( aAuthor );

            aAuthor.Append( this );
        }

        public void Remove( IAuthor aAuthor )
        {
            if ( mAuthors.Contains( aAuthor ) ) mAuthors.Remove( aAuthor );
            aAuthor.Remove( this );
        }

        public IEnumerable<IBookItem> Items => mItems;

        public void Append( IBookItem aItem )
        {
            if ( mItems.Contains( aItem ) ) return;
            mItems.Add( aItem );

            aItem.Book = this;
        }

        public void Remove( IBookItem aItem )
        {
            if ( mItems.Contains( aItem ) ) mItems.Remove( aItem );

            aItem.Book = null;
        }
    }
}
