using System.Collections.Generic;
using System.Threading.Tasks;
using Abp;
using Geek.AbpGeek.Dto;

namespace Geek.AbpGeek.Gdpr
{
    public interface IUserCollectedDataProvider
    {
        Task<List<FileDto>> GetFiles(UserIdentifier user);
    }
}
