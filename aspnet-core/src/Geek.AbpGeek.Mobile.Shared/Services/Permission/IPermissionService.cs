namespace Geek.AbpGeek.Services.Permission
{
    public interface IPermissionService
    {
        bool HasPermission(string key);
    }
}