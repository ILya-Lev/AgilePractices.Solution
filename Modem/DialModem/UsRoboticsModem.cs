﻿using System.IO;

namespace Modem.DialModem
{
    public class UsRoboticsModem : IModem, IDialer
    {
        public void Dial(char[] number)
        {
            throw new System.NotImplementedException();
        }

        public void Hangup()
        {
            throw new System.NotImplementedException();
        }

        public void Send(Stream data)
        {
            throw new System.NotImplementedException();
        }

        public Stream Receive()
        {
            throw new System.NotImplementedException();
        }
    }
}