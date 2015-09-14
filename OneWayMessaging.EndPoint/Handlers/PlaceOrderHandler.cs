using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NServiceBus;
using NServiceBus.Hosting.Profiles;
using OneWayMessaging.Contracts.Commands;

namespace OneWayMessaging.EndPoint.Handlers
{

    public class PlaceOrderHandler : IHandleMessages<PlaceOrder>
    {
        public void Handle(PlaceOrder message)
        {
           Console.WriteLine("Order received {0}", message.OrderId);
        }
    }
}
