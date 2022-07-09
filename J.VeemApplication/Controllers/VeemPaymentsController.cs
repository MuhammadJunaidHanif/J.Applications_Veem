using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using VeemIntegrations.Models;

namespace J.TestApplication.Controllers
{
    [ApiController]
    [Route("api/payment-gatway/veem")]
    public class VeemPaymentsController : ControllerBase
    {

        private readonly ILogger<VeemPaymentsController> _logger;

        public VeemPaymentsController(ILogger<VeemPaymentsController> logger)
        {
            _logger = logger;
        }

        [HttpGet("payments/{paymentId}")]
        public async Task<PaymentDetails> GetPaymentById(int paymentId)
        {
            try
            {
                var url = $"https://sandbox-api.veem.com/veem/v1.1/payments/{paymentId}";
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri(url),
                    Headers =
                    {
                        { "Accept", "application/json" },
                    },
                };

                return await ExecuteRequest<PaymentDetails>(request);
            }
            catch (Exception ex)
            {
                //Log Error here
                return null;
            }
        }
        
        [HttpGet("payments")]
        public async Task<PaymentsResult> GetPayments()
        {
            try
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri("https://sandbox-api.veem.com/veem/v1.1/payments")
                };

                return await ExecuteRequest<PaymentsResult>(request);
            }
            catch (Exception ex)
            {
                //Log Error here
                return null;
            }
        }


        [HttpPost("payments")]
        public async Task<PaymentDetails> CreatePayment(CreatePaymentRequest paymentrequest)
        {
            try
            {
                var returnResponse = new PaymentDetails();

                var requestBody = JsonConvert.SerializeObject(paymentrequest);
         
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Post,
                    RequestUri = new Uri("https://sandbox-api.veem.com/veem/v1.1/payments"),
                    Content = new StringContent(requestBody)
                    {
                        Headers ={ContentType = new MediaTypeHeaderValue("application/json")}
                    }
                };
                return await ExecuteRequest<PaymentDetails>(request);
            }

            catch (Exception ex)
            {
                //Log Error here
                return null;
            }
        }

        [HttpPost("payments/{paymentId}/approve")]
        public async Task<PaymentDetails> ApprovePayment(int paymentId)
        {
            try
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Post,
                    RequestUri = new Uri($"https://sandbox-api.veem.com/veem/v1.1/payments/{paymentId}/approve"),
                };

                return await ExecuteRequest<PaymentDetails>(request);
            }
            catch (Exception ex)
            {
                //Log Error here
                return null;
            }
        }

        [HttpPost("payments/{paymentId}/cancel")]
        public async Task<PaymentDetails> CancelPayment(int paymentId)
        {
            try
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Post,
                    RequestUri = new Uri($"https://sandbox-api.veem.com/veem/v1.1/payments/{paymentId}/cancel"),
                    Headers = { { "Accept", "application/json" }, },

                };

                return await ExecuteRequest<PaymentDetails>(request);
            }
            catch (Exception ex)
            {
                //Log Error here
                return null;
            }
        }

        private async Task<TResult> ExecuteRequest<TResult>(HttpRequestMessage request)
        {
            var client = new HttpClient();
            request.Headers.Add("Authorization", "Bearer e26cc333-ed73-4aa4-bf5f-26a66d4f22a6");
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("X-REQUEST-ID", Guid.NewGuid().ToString());
            using (var response = await client.SendAsync(request))
            {
                //response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<TResult>(body);

            }
        }
    }
}
