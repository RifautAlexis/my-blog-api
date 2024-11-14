namespace Api.Entities;

public class Article : BaseEntity
{
    public required string Slug { get; set; }
    public required string Title { get; set; }
    public required string Content { get; set; }
    public virtual ICollection<ArticleTag> ArticleTags { get; set; }
    public virtual ICollection<StoryArticle> StoryArticles { get; set; }
}
