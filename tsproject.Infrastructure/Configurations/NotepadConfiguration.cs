using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tsproject.Core.Entities;

namespace tsproject.Infrastructure.Configurations
{
    public class NotepadConfiguration: IEntityTypeConfiguration<Notepad>
    {
        public void Configure(EntityTypeBuilder<Notepad> entity)
        {
            entity.ToTable("directorys");
            entity.HasData(new Core.Entities.Notepad[]
            {
                new Notepad
                {
                    Name ="Блокнот 1"
                },
                new Notepad
                {
                    Name ="Блокнот 2"
                }
            });
        }
    }
}
