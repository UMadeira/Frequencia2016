using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
