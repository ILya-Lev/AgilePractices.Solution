using System;
using System.IO;

namespace Modem
{
    class DedicatedModemController : ModemConnectionController
    {
        private bool _isConnected = false;
        public override void Dial(char[] number) => _isConnected = true;

        public override void Hangup() => _isConnected = false;

        public override void Send(Stream data)
        {
            if (!_isConnected)
                throw new Exception("Dial at first!");
            SendImpl(data);
        }

        public override Stream Receive()
        {
            if (!_isConnected)
                throw new Exception("Dial at first");
            return ReceiveImpl();
        }

        public DedicatedModemController(IModemImplementation modemImpl) : base(modemImpl)
        {
        }
    }
}