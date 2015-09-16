using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NServiceBus;
using NServiceBus.MessageMutator;

namespace OneWayMessagingApi.Mutator
{
    public class AuthMutator : IMutateOutgoingTransportMessages
    {
        public void MutateOutgoing(object[] messages, TransportMessage transportMessage)
        {
            Headers.SetMessageHeader(transportMessage, "application", "quoting");
        }
    }
}