namespace Modem.Clients
{
    public class DedicatedUser
    {
        private readonly IDedModem _modem;

        public DedicatedUser(IDedModem modem)
        {
            _modem = modem;
        }
    }
}