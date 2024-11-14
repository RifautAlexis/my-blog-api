namespace Api.Entities;

public class Tag : BaseEntity
{
    public required string Name { get; set; }
    public virtual ICollection<ArticleTag> ArticleTags { get; set; }
}