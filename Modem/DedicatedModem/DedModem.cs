using System;
using System.IO;

namespace Modem.DedicatedModem
{
    public class DedModem : IModem
    {
        public void Send(Stream data)
        {
            throw new NotImplementedException();
        }

        public Stream Receive()
        {
            throw new NotImplementedException();
        }
    }
}
