using System.Threading.Tasks;
using Abp.Domain.Policies;

namespace Geek.AbpGeek.Authorization.Users
{
    public interface IUserPolicy : IPolicy
    {
        Task CheckMaxUserCountAsync(int tenantId);
    }
}
