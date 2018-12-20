using System.Threading.Tasks;
using Geek.AbpGeek.ApiClient.Models;

namespace Geek.AbpGeek.Services.Account
{
    public interface IAccountService
    {
        AbpAuthenticateModel AbpAuthenticateModel { get; set; }
        AbpAuthenticateResultModel AuthenticateResultModel { get; set; }
        Task LoginUserAsync();
    }
}
