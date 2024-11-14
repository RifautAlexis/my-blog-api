using Api.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Api.DataAccess.Configurations;

public class StoryConfiguration : IEntityTypeConfiguration<Story>
{
    public void Configure(EntityTypeBuilder<Story> entity)
    {
        entity.Property(e => e.Id)
            .ValueGeneratedOnAdd();
        entity.Property(e => e.Title)
            .IsRequired();
        entity.Property(e => e.Description)
            .IsRequired();

        entity.HasKey(e => e.Id);

        entity.ToTable("Story");
    }
}