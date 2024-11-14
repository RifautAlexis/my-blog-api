using Api.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace Api.DataAccess.Configurations;

public class ArticleTagConfiguration : IEntityTypeConfiguration<ArticleTag>
{
    public void Configure(EntityTypeBuilder<ArticleTag> entity)
    {
        entity.Property(sc => sc.ArticleId)
            .ValueGeneratedNever();
        entity.Property(sc => sc.TagId)
            .ValueGeneratedNever();

        entity.HasKey(sc => new { sc.ArticleId, sc.TagId });

       entity.HasOne(sc => sc.Article)
            .WithMany(s => s.ArticleTags)
            .HasForeignKey(sc => sc.ArticleId);
       entity
            .HasOne(sc => sc.Tag)
            .WithMany(c => c.ArticleTags)
            .HasForeignKey(sc => sc.TagId);

       entity.ToTable("ArticleTag");
    }
}