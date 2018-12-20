using System.Threading.Tasks;
using Abp.Application.Services;
using Geek.AbpGeek.MultiTenancy.Dto;
using Geek.AbpGeek.MultiTenancy.Payments.Dto;
using Abp.Application.Services.Dto;

namespace Geek.AbpGeek.MultiTenancy.Payments
{
    public interface IPaymentAppService : IApplicationService
    {
        Task<PaymentInfoDto> GetPaymentInfo(PaymentInfoInput input);

        Task<CreatePaymentResponse> CreatePayment(CreatePaymentDto input);

        Task CancelPayment(CancelPaymentDto input);

        Task<ExecutePaymentResponse> ExecutePayment(ExecutePaymentDto input);

        Task<PagedResultDto<SubscriptionPaymentListDto>> GetPaymentHistory(GetPaymentHistoryInput input);
    }
}
