using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeemIntegrations.Models
{
    public class Payee
    {
        public string BusinessName { get; set; }
        public string CountryCode { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Type { get; set; }
        public string Phone { get; set; }
    }
    public class PayeeAmount
    {
        public string Currency { get; set; }
        public Double Number { get; set; }
    }
}
