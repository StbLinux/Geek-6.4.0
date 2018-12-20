using Geek.AbpGeek.MultiTenancy.Payments;

namespace Geek.AbpGeek.Web.Models.Payment
{
    public class CancelPaymentModel
    {
        public string PaymentId { get; set; }

        public SubscriptionPaymentGatewayType Gateway { get; set; }
    }
}