namespace Library.Model.Factory
{
    interface IAbstractFactory
    {
        IBook     CreateBook();
        IBookItem CreateBookItem( IBook aBook = null );
        IAuthor   CreateAuthor();
    }
}
