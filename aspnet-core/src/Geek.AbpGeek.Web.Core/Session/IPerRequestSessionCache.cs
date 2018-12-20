using System.Threading.Tasks;
using Geek.AbpGeek.Sessions.Dto;

namespace Geek.AbpGeek.Web.Session
{
    public interface IPerRequestSessionCache
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformationsAsync();
    }
}
