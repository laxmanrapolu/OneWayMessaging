using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FullDuplex.Contracts.Messages;
using NServiceBus;
using NServiceBus.Hosting.Profiles;
using OneWayMessaging.Contracts.Commands;

namespace OneWayMessaging.EndPoint.Handlers
{

    public class PlaceOrderHandler : IHandleMessages<PlaceOrder>
    {
        public IBus Bus;

        public PlaceOrderHandler(IBus bus)
        {
            Bus = bus;
        }
        public void Handle(PlaceOrder message)
        {
           // throw new Exception("Test exception");
           Console.WriteLine("Order received with Id : {0}", message.OrderId);

          #region FullDuplex

            var confirmPurchase = new ConfirmPurchase()
            {
                OrderId = message.OrderId,
                CustomerId = message.CustomerId
            };

            Bus.Send(confirmPurchase);

            #endregion
        }
    }
}
