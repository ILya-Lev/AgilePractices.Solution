using System.IO;

namespace Modem
{
    public abstract class ModemConnectionController : IModem, IDedModem
    {
        private readonly IModemImplementation _modemImpl;

        protected ModemConnectionController(IModemImplementation modemImpl)
        {
            _modemImpl = modemImpl;
        }

        public abstract void Dial(char[] number);
        public abstract void Hangup();
        public abstract void Send(Stream data);
        public abstract Stream Receive();

        protected void DialImpl(char[] number) => _modemImpl.Dial(number);
        protected void HangupImpl() => _modemImpl.Hangup();
        protected void SendImpl(Stream data) => _modemImpl.Send(data);
        protected Stream ReceiveImpl() => _modemImpl.Receive();
    }
}