using System;
using System.IO;

namespace Modem.DedicatedModem
{
    public class DedicatedModemAdapter : IModem
    {
        private readonly DedModem _modem;
        private bool _connected;

        public DedicatedModemAdapter(DedModem modem)
        {
            _modem = modem;
            _connected = false;
        }
        public void Dial(char[] number) => _connected = true;

        public void Hangup() => _connected = false;

        public void Send(Stream data)
        {
            if (!_connected)
                throw new Exception("Dial before sending data");
            _modem.Send(data);
        }

        public Stream Receive()
        {
            if (!_connected)
                throw new Exception("Dial before receiving data");
            return _modem.Receive();
        }
    }
}