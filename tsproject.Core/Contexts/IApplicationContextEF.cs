using tsproject.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace tsproject.Core.Context
{
#pragma warning disable CS8618
    public interface IApplicationContextEF
    {
        DbSet<tsproject.Core.Entities.Directory> Directorys { get; set; }
        DbSet<tsproject.Core.Entities.Notepad> Notepads { get; set; }
        DbSet<tsproject.Core.Entities.Note> Notes { get; set; }

        Task<int> SaveChangesAsync();
    }
}
