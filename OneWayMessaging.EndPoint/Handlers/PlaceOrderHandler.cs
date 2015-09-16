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
           #region FaultTolerance
            // throw new Exception("Test exception");
            #endregion
            
           Console.WriteLine("Order received with Id : {0}", message.OrderId);
           Console.WriteLine("");

           #region FullDuplex

           var confirmPurchase = new ConfirmPurchase()
           {
               OrderId = message.OrderId,
               CustomerId = message.CustomerId
           };
           Console.WriteLine("Sending Confirm Purchase request");
           Console.WriteLine("");
           Bus.Send(confirmPurchase);

           #endregion
        }
    }
}
