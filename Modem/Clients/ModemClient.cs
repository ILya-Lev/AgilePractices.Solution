namespace Modem.Clients
{
    public class ModemClient
    {
        private readonly IModem _modem;

        public ModemClient(IModem modem)
        {
            _modem = modem;
        }
    }
}
