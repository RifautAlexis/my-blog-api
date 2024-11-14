using Api.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.DataAccess.Configurations;

public class StoryArticleConfiguration : IEntityTypeConfiguration<StoryArticle>
{
    public void Configure(EntityTypeBuilder<StoryArticle> entity)
    {
        entity.Property(sc => sc.ArticleId)
            .ValueGeneratedNever();
        entity.Property(sc => sc.StoryId)
            .ValueGeneratedNever();

        entity.HasKey(sc => new { sc.ArticleId, sc.StoryId });

        entity.Property(e => e.ReadingOrder)
            .IsRequired();

        entity.HasOne(sc => sc.Article)
             .WithMany(s => s.StoryArticles)
             .HasForeignKey(sc => sc.ArticleId);
        entity
             .HasOne(sc => sc.Story)
             .WithMany(c => c.StoryArticles)
             .HasForeignKey(sc => sc.StoryId);

        entity.ToTable("StoryArticle");
    }
}
