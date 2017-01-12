using System.Collections.Generic;

namespace Library.Model
{
    public interface IBook
    {
        string ISBN { get; }
        string Title { get; set; }
        string Summary { get; set; }
        
        IEnumerable<IAuthor> Authors { get; }
        void Append( IAuthor aAuthor );
        void Remove( IAuthor aAuthor );

        IEnumerable<IBookItem> Items { get; }
        void Append( IBookItem aItem );
        void Remove( IBookItem aItem );
    }
}
