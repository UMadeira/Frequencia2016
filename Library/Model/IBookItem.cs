using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Model
{
    public interface IBookItem
    {
        string Barcode { get; set; }

        IBook Book { get; set; }
    }
}
