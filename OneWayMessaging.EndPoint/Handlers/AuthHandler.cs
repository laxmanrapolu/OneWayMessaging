using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NServiceBus;
using OneWayMessaging.Contracts.Commands;

namespace OneWayMessaging.EndPoint.Handlers
{
    public class AuthHandler : IHandleMessages<PlaceOrder>
    {
        public IBus _bus;

        public AuthHandler(IBus Bus)
        {
            _bus = Bus;
        }
        public void Handle(PlaceOrder message)
        {
            var application = _bus.GetMessageHeader(message, "application");
            if (application == "quoting")
            {
                Console.WriteLine("Authentication failed");
                _bus.DoNotContinueDispatchingCurrentMessageToHandlers();
                return;
            }
            Console.WriteLine("User Authenticated");
        }
    }
}
