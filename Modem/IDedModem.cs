using System.IO;

namespace Modem
{
    public interface IDedModem
    {
        void Send(Stream data);
        Stream Receive();
    }
}
