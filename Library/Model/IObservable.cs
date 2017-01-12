using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Library.Model
{
    public delegate void NotifyHandler( IObservable aObservable, object aData );

    public interface IObservable
    {
        event NotifyHandler OnNotify;

        void Notify( object aData = null );
    }
}
