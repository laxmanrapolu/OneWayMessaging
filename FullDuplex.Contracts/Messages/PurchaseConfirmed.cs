using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullDuplex.Contracts.Messages
{
    public class PurchaseConfirmed
    {
        public Guid CustomerId { get; set; }
        public Guid ReceiptId { get; set; }
    }
}
