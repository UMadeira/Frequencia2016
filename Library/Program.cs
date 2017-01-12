using System;
using Library.Model;
using Library.Model.Factory;

namespace Library
{
    class Program
    {
        static void Main( string[] args )
        {
            var factory = new Model.Observables.Factory( new Factory() );

            IBook book = factory.CreateBook();

            IObservable observable = book as IObservable;
            if ( observable != null )
            { 
                observable.OnNotify += ( o, d ) => Console.WriteLine( "Book changed..." );
            }

            book.Title = "Design Patterns";

            Console.ReadKey();
        }
    }
}
