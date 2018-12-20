using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Geek.AbpGeek.MultiTenancy.Accounting.Dto;

namespace Geek.AbpGeek.MultiTenancy.Accounting
{
    public interface IInvoiceAppService
    {
        Task<InvoiceDto> GetInvoiceInfo(EntityDto<long> input);

        Task CreateInvoice(CreateInvoiceDto input);
    }
}
