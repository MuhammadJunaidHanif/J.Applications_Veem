using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeemIntegrations.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);

    public class PaymentDetails
    {
        public int Id { get; set; }
        public List<Attachment> Attachments { get; set; }
        public int BatchItemId { get; set; }
        public List<string> ccEmails { get; set; }
        public string ClaimLink { get; set; }
        public DateTime DueDate { get; set; }
        public string ExchangeRateQuoteId { get; set; }
        public string ExternalInvoiceRefId { get; set; }
        public string Notes { get; set; }
        public Payee Payee { get; set; }
        public PayeeAmount PayeeAmount { get; set; }
        public string PaymentAction { get; set; }
        public PaymentApproval PaymentApproval { get; set; }
        public PaymentApprovalRequest PaymentApprovalRequest { get; set; }
        public string PurposeOfPayment { get; set; }
        public PushPaymentInformation PushPaymentInfo { get; set; }
        public string Status { get; set; }
        public DateTime TimeCreated { get; set; }
        public DateTime TimeUpdated { get; set; }
    }

    public class PaymentApproval
    {
        public string ApprovalStatus { get; set; }
        public int ApproverNumber { get; set; }
        public int ApproverNumberRequired { get; set; }
        public List<UserApprovalList> UserApprovalList { get; set; }
    }
    public class PaymentApprovalRequest
    {
        public int AccountId { get; set; }
        public int UserId { get; set; }
    }

    public class PushPaymentInformation
    {
        public Amount Amount { get; set; }
        public string PushPaymentInfo { get; set; }
        public string Reference { get; set; }
    }

    public class UserApprovalList
    {
        public string ApprovalStatus { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
    }

}
