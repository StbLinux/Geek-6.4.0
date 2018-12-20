using Xamarin.Forms.Internals;

namespace Geek.AbpGeek.Behaviors
{
    [Preserve(AllMembers = true)]
    public interface IAction
    {
        bool Execute(object sender, object parameter);
    }
}