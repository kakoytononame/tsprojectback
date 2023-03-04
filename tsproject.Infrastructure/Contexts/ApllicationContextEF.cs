using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tsproject.Core.Context;
using tsproject.Core.Entities;
using tsproject.Infrastructure;
namespace tsproject.Infrastructure.Contexts
{
    public class ApplicationContextEF: DbContext
    {
        public DbSet<tsproject.Core.Entities.Directory> Directories { get; set; }
        public DbSet<Notepad> Notepads { get; set;}
        public DbSet<Note> Notes { get; set;}

        public ApplicationContextEF(DbContextOptions<ApplicationContextEF> options) : base(options)
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }
    }
}
