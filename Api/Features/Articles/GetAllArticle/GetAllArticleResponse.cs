using Api.Entities;

namespace Api.Features.Articles.GetAllArticle;

public class GetAllArticleResponse
{
    public required string Slug { get; set; }
    public required string Title { get; set; }
    public required List<TagDto> Tags { get; set; }
    public required string CreatedAt { get; set; }
    public required string UpdatedAt { get; set; }
}

public class TagDto
{
    public required Guid Id { get; set; }
    public required string Name { get; set; }
}