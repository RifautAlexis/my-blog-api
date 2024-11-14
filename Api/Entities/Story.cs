namespace Api.Entities;

public class Story : BaseEntity
{
    public required string Title { get; set; }
    public required string Description { get; set; }
    public virtual ICollection<StoryArticle> StoryArticles { get; set; }
}
