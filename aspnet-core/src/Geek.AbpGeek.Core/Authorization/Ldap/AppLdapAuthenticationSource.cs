using Abp.Zero.Ldap.Authentication;
using Abp.Zero.Ldap.Configuration;
using Geek.AbpGeek.Authorization.Users;
using Geek.AbpGeek.MultiTenancy;

namespace Geek.AbpGeek.Authorization.Ldap
{
    public class AppLdapAuthenticationSource : LdapAuthenticationSource<Tenant, User>
    {
        public AppLdapAuthenticationSource(ILdapSettings settings, IAbpZeroLdapModuleConfig ldapModuleConfig)
            : base(settings, ldapModuleConfig)
        {
        }
    }
}