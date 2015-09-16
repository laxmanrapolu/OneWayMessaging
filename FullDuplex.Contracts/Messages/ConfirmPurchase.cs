using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullDuplex.Contracts.Messages
{
    public class ConfirmPurchase
    {
        public Guid CustomerId { get; set; }
        public Guid OrderId { get; set; }
    }
}
