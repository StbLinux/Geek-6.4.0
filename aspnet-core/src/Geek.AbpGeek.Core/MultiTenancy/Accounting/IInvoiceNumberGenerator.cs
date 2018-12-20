using System.Threading.Tasks;
using Abp.Dependency;

namespace Geek.AbpGeek.MultiTenancy.Accounting
{
    public interface IInvoiceNumberGenerator : ITransientDependency
    {
        Task<string> GetNewInvoiceNumber();
    }
}