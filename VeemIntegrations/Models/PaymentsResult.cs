using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeemIntegrations.Models
{
    public class PaymentsResult
    {
        public List<Content> Content { get; set; }
        public int NumberOfElements { get; set; }
        public int Size { get; set; }
        public int Number { get; set; }
        public bool Last { get; set; }
        public bool First { get; set; }
        public object Sort { get; set; }
        public int TotalPages { get; set; }
        public int TotalElements { get; set; }
    }

    public class Content
    {
        public int Id { get; set; }
        public string RequestId { get; set; }
        public List<string> ccEmails { get; set; }
        public PayeeAmount PayeeAmount { get; set; }
        public string Status { get; set; }
        public ExchangeRate ExchangeRate { get; set; }
        public DateTime TimeCreated { get; set; }
        public DateTime TimeUpdated { get; set; }
    }

    public class ExchangeRate
    {
        public double FromAmount { get; set; }
        public string FromCurrency { get; set; }
        public double ToAmount { get; set; }
        public string ToCurrency { get; set; }
    }

   


}
