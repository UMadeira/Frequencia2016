using System.Collections.Generic;

namespace Library.Model.Observables
{
    class ObservableBook : IBook, IObservable
    {
        public ObservableBook( IBook aBook )
        {
            Book = aBook;
        }

        private IBook Book { get; }

        public string ISBN => Book.ISBN;

        public string Title
        {
            get { return Book.Title; }
            set { Book.Title = value; Notify(); }
        }

        public string Summary
        {
            get { return Book.Summary; }
            set { Book.Summary = value; Notify(); }
        }

        public IEnumerable<IAuthor> Authors => Book.Authors;

        public void Append( IAuthor aAuthor )
        {
            Book.Append( aAuthor );
            Notify();
        }
        public void Remove( IAuthor aAuthor )
        {
            Book.Remove( aAuthor );
            Notify();
        }
        public IEnumerable<IBookItem> Items => Book.Items;

        public void Append( IBookItem aItem )
        {
            Book.Append( aItem );
            Notify();
        }

        public void Remove( IBookItem aItem )
        {
            Book.Remove( aItem );
            Notify();
        }

        public event NotifyHandler OnNotify;

        public void Notify( object aData = null )
        {
            OnNotify?.Invoke( this, aData );
        }
    }
}
