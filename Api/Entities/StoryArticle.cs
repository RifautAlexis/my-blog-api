namespace Api.Entities;

public class StoryArticle
{
    public Guid StoryId { get; set; }
    public Guid ArticleId { get; set; }
    public required int ReadingOrder { get; set; }

    public required Story Story { get; set; }
    public required Article Article { get; set; }
}
