namespace Geek.AbpGeek.Authorization.Accounts.Dto
{
    public class SwitchToLinkedAccountOutput
    {
        public string SwitchAccountToken { get; set; }

        public string TenancyName { get; set; }
    }
}