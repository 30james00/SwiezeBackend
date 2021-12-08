using System.Threading.Tasks;
using Application.Interfaces;
using Stripe;

namespace Infrastructure.Payments
{
    public class PaymentsAccessor : IPaymentsAccessor
    {
        public async Task<string> Pay(int value)
        {
            var paymentIntentService = new PaymentIntentService();
            var paymentIntent = await paymentIntentService.CreateAsync(new PaymentIntentCreateOptions
            {
                Amount = value,
                Currency = "eur",
                AutomaticPaymentMethods = new PaymentIntentAutomaticPaymentMethodsOptions
                {
                    Enabled = true,
                },
            });

            return paymentIntent.ClientSecret;
        }
    }
}