using System.Collections.Generic;

namespace Library.Model
{
    public interface IAuthor
    {
        string Name { get; set; }
        string Biography { get; set; }

        IEnumerable<IBook> Books { get; }
        void Append( IBook aBook );
        void Remove( IBook aBook );
    }
}
