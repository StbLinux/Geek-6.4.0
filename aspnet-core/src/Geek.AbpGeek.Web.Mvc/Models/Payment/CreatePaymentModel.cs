using Geek.AbpGeek.Editions;
using Geek.AbpGeek.MultiTenancy.Payments;

namespace Geek.AbpGeek.Web.Models.Payment
{
    public class CreatePaymentModel
    {
        public int EditionId { get; set; }

        public PaymentPeriodType? PaymentPeriodType { get; set; }

        public EditionPaymentType EditionPaymentType { get; set; }

        public SubscriptionPaymentGatewayType Gateway { get; set; }
    }
}
