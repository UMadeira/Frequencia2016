using Library.Model.Classes;

namespace Library.Model.Factory
{
    public class Factory : IAbstractFactory
    {
        public IBook CreateBook()
        {
            return new Book();
        }

        public IBookItem CreateBookItem( IBook aBook = null )
        {
            return new BookItem();
        }

        public IAuthor CreateAuthor()
        {
            return new Author();
        }
    }
}
