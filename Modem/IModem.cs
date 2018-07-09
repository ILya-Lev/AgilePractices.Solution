using System.IO;

namespace Modem
{
    public interface IModem
    {
        void Dial(char[] number);
        void Hangup();
        void Send(Stream data);
        Stream Receive();
    }
}