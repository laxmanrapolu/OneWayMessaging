using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FullDuplex.Contracts.Messages;
using NServiceBus;

namespace FullDuplex.Endpoint.Handlers
{
    public class ConfirmPurchaseHandler : IHandleMessages<ConfirmPurchase>
    {
        private IBus Bus;

        public ConfirmPurchaseHandler(IBus bus)
        {
            Bus = bus;
        }

        public void Handle(ConfirmPurchase message)
        {
            Console.WriteLine("Confirming Purchase for Customer {0} with Order Id {1}", message.CustomerId, message.OrderId);

            #region Reply

            var purchaseConfirmed = new PurchaseConfirmed()
            {
                CustomerId = message.CustomerId,
                ReceiptId = Guid.NewGuid()
            };
            try
            {
                Bus.Reply(purchaseConfirmed);
            }
            catch (Exception ex)
            {
                
          Console.WriteLine(ex);
            }
            

            #endregion
        }
    }
}
