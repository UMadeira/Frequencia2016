namespace Library.Model
{
    public delegate void NotifyHandler( IObservable aObservable, object aData );

    public interface IObservable
    {
        event NotifyHandler OnNotify;

        void Notify( object aData = null );
    }
}
