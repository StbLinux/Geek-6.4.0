using System.Threading.Tasks;
using Geek.AbpGeek.Views;
using Xamarin.Forms;

namespace Geek.AbpGeek.Services.Modal
{
    public interface IModalService
    {
        Task ShowModalAsync(Page page);

        Task ShowModalAsync<TView>(object navigationParameter) where TView : IXamarinView;

        Task<Page> CloseModalAsync();
    }
}
