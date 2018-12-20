using Abp.Configuration;

namespace Geek.AbpGeek.Timing.Dto
{
    public class GetTimezonesInput
    {
        public SettingScopes DefaultTimezoneScope { get; set; }
    }
}
