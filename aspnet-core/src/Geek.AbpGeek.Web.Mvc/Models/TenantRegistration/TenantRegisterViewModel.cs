using Geek.AbpGeek.Editions;
using Geek.AbpGeek.Editions.Dto;
using Geek.AbpGeek.Security;
using Geek.AbpGeek.MultiTenancy.Payments;
using Geek.AbpGeek.MultiTenancy.Payments.Dto;

namespace Geek.AbpGeek.Web.Models.TenantRegistration
{
    public class TenantRegisterViewModel
    {
        public PasswordComplexitySetting PasswordComplexitySetting { get; set; }

        public int? EditionId { get; set; }

        public string PaymentId { get; set; }

        public SubscriptionPaymentGatewayType? Gateway { get; set; }

        public SubscriptionStartType? SubscriptionStartType { get; set; }

        public EditionSelectDto Edition { get; set; }

        public EditionPaymentType EditionPaymentType { get; set; }

        public bool ShowPaymentExpireNotification()
        {
            return !string.IsNullOrEmpty(PaymentId);
        }
    }
}
