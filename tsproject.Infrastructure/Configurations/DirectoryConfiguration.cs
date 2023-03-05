using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tsproject.Infrastructure.Configurations
{
    public class DirectoryConfiguration: IEntityTypeConfiguration<Core.Entities.Directory>
    {
        public void Configure(EntityTypeBuilder<Core.Entities.Directory> entity)
        {
            entity.ToTable("directorys");
            entity.HasData(new Core.Entities.Directory[]
            {
                new Core.Entities.Directory
                {
                    Name ="Папка 1"
                },
                new Core.Entities.Directory
                {
                    Name ="Папка 2"
                }
            });
        }

    }
}
