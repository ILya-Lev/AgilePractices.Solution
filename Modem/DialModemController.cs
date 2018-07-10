using System.IO;

namespace Modem
{
    class DialModemController : ModemConnectionController
    {
        public override void Dial(char[] number) => DialImpl(number);

        public override void Hangup() => HangupImpl();

        public override void Send(Stream data) => SendImpl(data);

        public override Stream Receive() => ReceiveImpl();

        public DialModemController(IModemImplementation modemImpl) : base(modemImpl)
        {
        }
    }
}