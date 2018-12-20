using System.Threading.Tasks;
using Geek.AbpGeek.ApiClient.Models;

namespace Geek.AbpGeek.ApiClient
{
    public interface IAccessTokenManager
    {
        Task<string> GetAccessTokenAsync();
         
        Task<AbpAuthenticateResultModel> LoginAsync();

        void Logout();

        bool IsUserLoggedIn { get; }
    }
}