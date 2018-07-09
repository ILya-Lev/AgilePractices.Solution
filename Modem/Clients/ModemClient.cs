namespace Modem.Clients
{
    public class ModemClient
    {
        private readonly IModem _modem;
        private readonly IDialer _dialer;

        public ModemClient(IModem modem, IDialer dialer)
        {
            _modem = modem;
            _dialer = dialer;
        }
    }
}
