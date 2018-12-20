using Abp.Domain.Services;

namespace Geek.AbpGeek
{
    public abstract class AbpGeekDomainServiceBase : DomainService
    {
        /* Add your common members for all your domain services. */

        protected AbpGeekDomainServiceBase()
        {
            LocalizationSourceName = AbpGeekConsts.LocalizationSourceName;
        }
    }
}
