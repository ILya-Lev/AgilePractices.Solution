using System.IO;

namespace Modem
{
    public interface IDialer
    {
        void Dial(char[] number);
        void Hangup();
    }

    public interface IModem
    {
        void Send(Stream data);
        Stream Receive();
    }
}