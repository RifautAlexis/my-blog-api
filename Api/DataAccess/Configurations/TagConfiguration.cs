using Api.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Api.DataAccess.Configurations;

public class TagConfiguration : IEntityTypeConfiguration<Tag>
{
    public void Configure(EntityTypeBuilder<Tag> entity)
    {
        entity.Property(e => e.Id)
            .ValueGeneratedOnAdd();
        entity.Property(e => e.Name)
            .IsRequired();

        entity.HasKey(e => e.Id);

        entity.ToTable("Tag");
    }
}