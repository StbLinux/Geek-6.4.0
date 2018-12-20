using System.Threading.Tasks;

namespace Geek.AbpGeek.Identity
{
    public interface ISmsSender
    {
        Task SendAsync(string number, string message);
    }
}