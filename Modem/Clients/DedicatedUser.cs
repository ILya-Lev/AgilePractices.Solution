namespace Modem.Clients
{
    public class DedicatedUser
    {
        private readonly IModem _modem;

        public DedicatedUser(IModem modem)
        {
            _modem = modem;
        }
    }
}