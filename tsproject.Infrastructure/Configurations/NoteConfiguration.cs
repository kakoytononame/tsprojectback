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
    public class NoteConfiguration: IEntityTypeConfiguration<Note>
    {
        public void Configure(EntityTypeBuilder<Note> entity)
        {
            entity.ToTable("directorys");
            entity.HasData(new Note[]
            {
                new Note
                {
                    Name ="Заметка 1",
                    text ="Текст 1"
                    
                },
                new Note
                {
                    Name ="Заметка 2",
                    text="Текст 2"
                }
            });
        }
    }
}
