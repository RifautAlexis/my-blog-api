namespace Api.Entities;

public class ArticleTag
{
    public Guid ArticleId { get; set; }
    public Guid TagId { get; set; }

    public required Tag Tag { get; set; }
    public required Article Article { get; set; }
}
