using System.Collections.Generic;

namespace Library.Model.Classes
{
    class Author : IAuthor
    {
        private readonly IList<IBook> mBooks = new List<IBook>();

        public string Name { get; set; }
        public string Biography { get; set; }

        public IEnumerable<IBook> Books => mBooks;

        public void Append( IBook aBook )
        {
            if ( mBooks.Contains( aBook ) ) return;
            mBooks.Add( aBook );

            aBook.Append( this );
        }

        public void Remove( IBook aBook )
        {
            if ( mBooks.Contains( aBook ) ) mBooks.Remove( aBook );

            aBook.Remove( this );
        }
    }
}
