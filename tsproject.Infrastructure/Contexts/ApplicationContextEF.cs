using Microsoft.EntityFrameworkCore;
using tsproject.Core.Context;
using tsproject.Core.Entities;

namespace tsproject.Infrastructure.Contexts
{
    #pragma warning disable CS8618
    public class ApplicationContextEF : DbContext, IApplicationContextEF
    {
        
        public DbSet<Notepad> Notepads { get; set;}
        public DbSet<Note> Notes { get; set;}
        public DbSet<Core.Entities.Directory> Directorys { get; set; }

        public ApplicationContextEF(DbContextOptions<ApplicationContextEF> options) : base(options)
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        public Task<int> SaveChangesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
