using Api.DataAccess.Configurations;
using Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace Api.DataAccess;

public partial class BlogDbContext : DbContext
{

    public DbSet<Article> Articles { get; set; }
    public DbSet<Tag> Tags { get; set; }
    public DbSet<Story> Stories { get; set; }
    public DbSet<ArticleTag> ArticleTags { get; set; }
    public DbSet<StoryArticle> StoryArticles { get; set; }

    public BlogDbContext(DbContextOptions<BlogDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new ArticleConfiguration());
        modelBuilder.ApplyConfiguration(new ArticleTagConfiguration());
        modelBuilder.ApplyConfiguration(new StoryArticleConfiguration());
        modelBuilder.ApplyConfiguration(new StoryConfiguration());
        modelBuilder.ApplyConfiguration(new TagConfiguration());
    }
}