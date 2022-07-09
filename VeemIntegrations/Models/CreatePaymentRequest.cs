using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeemIntegrations.Models
{
    public class CreatePaymentRequest
    {
        public Amount Amount { get; set; }
        public bool ApproveAutomatically { get; set; }
        public List<Attachment> Attachments { get; set; }
        public List<string> ccEmails { get; set; }
        public DateTime DueDate { get; set; }
        public string ExchangeRateQuoteId { get; set; }
        public string ExternalInvoiceRefId { get; set; }
        public string Notes { get; set; }
        public Payee Payee { get; set; }
        public string PurposeOfPayment { get; set; }
    }

}
