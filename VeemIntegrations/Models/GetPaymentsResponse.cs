using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeemIntegrations.Models
{
    public class GetPaymentsResponse
    {
        public int Id { get; set; }
        public Amount Amount { get; set; }
        public List<Attachment> Attachments { get; set; }
        public string ClaimLink { get; set; }
        public int InvoiceId { get; set; }
        public Payee Payee { get; set; }
        public Payer Payer { get; set; }
        public string Status { get; set; }
        public DateTime TimeSent { get; set; }
    }


}
