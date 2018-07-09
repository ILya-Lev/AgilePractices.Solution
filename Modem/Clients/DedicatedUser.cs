using Modem.DedicatedModem;

namespace Modem.Clients
{
    public class DedicatedUser
    {
        private readonly DedModem _modem;

        public DedicatedUser(DedModem modem)
        {
            _modem = modem;
        }
    }
}