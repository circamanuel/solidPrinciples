using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversionPrinciple
{
    internal interface IMessageSender
    {
        void Send(string recipient, string message);

    }
}
