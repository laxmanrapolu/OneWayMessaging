using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FullDuplex.Contracts.Messages;
using NServiceBus;
using NServiceBus.Hosting.Profiles;

namespace OneWayMessaging.EndPoint.Handlers
{
    public class PurchaseConfirmedHandler : IHandleMessages<PurchaseConfirmed>
    {
        public void Handle(PurchaseConfirmed message)
        {
            Console.WriteLine("Received reply from full duplex on purchase confirmation with receipt no {0}", message.ReceiptId);
        }
    }
}
