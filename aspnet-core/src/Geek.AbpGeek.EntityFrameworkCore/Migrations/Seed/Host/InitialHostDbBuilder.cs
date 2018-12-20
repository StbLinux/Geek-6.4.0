using Geek.AbpGeek.EntityFrameworkCore;

namespace Geek.AbpGeek.Migrations.Seed.Host
{
    public class InitialHostDbBuilder
    {
        private readonly AbpGeekDbContext _context;

        public InitialHostDbBuilder(AbpGeekDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            new DefaultEditionCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();

            _context.SaveChanges();
        }
    }
}
