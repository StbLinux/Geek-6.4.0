using Abp.AutoMapper;
using Geek.AbpGeek.Editions;
using Geek.AbpGeek.MultiTenancy.Payments.Dto;

namespace Geek.AbpGeek.Web.Areas.AppAreaName.Models.SubscriptionManagement
{
    [AutoMapTo(typeof(ExecutePaymentDto))]
    public class PaymentResultViewModel : SubscriptionPaymentDto
    {
        public EditionPaymentType EditionPaymentType { get; set; }
    }
}