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
