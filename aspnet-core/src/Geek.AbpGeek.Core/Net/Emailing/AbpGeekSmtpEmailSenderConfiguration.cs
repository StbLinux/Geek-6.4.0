using Abp.Configuration;
using Abp.Net.Mail;
using Abp.Net.Mail.Smtp;
using Abp.Runtime.Security;

namespace Geek.AbpGeek.Net.Emailing
{
    public class AbpGeekSmtpEmailSenderConfiguration : SmtpEmailSenderConfiguration
    {
        public AbpGeekSmtpEmailSenderConfiguration(ISettingManager settingManager) : base(settingManager)
        {

        }

        public override string Password => SimpleStringCipher.Instance.Decrypt(GetNotEmptySettingValue(EmailSettingNames.Smtp.Password));
    }
}