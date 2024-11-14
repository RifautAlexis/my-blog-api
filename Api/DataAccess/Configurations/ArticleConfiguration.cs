using Api.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Api.DataAccess.Configurations;

public class ArticleConfiguration : IEntityTypeConfiguration<Article>
{
    public void Configure(EntityTypeBuilder<Article> entity)
    {
        entity.Property(e => e.Id)
            .ValueGeneratedOnAdd();
        entity.Property(e => e.Slug)
            .IsRequired();
        entity.Property(e => e.Title)
            .IsRequired();
        entity.Property(e => e.Content)
            .IsRequired();

        entity.HasKey(e => e.Id);

        entity.ToTable("Article");
    }
}
