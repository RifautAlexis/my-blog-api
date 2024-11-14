using Api.DataAccess;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Api.Features.Articles.GetAllArticle;

public class GetAllArticleHandler(BlogDbContext context, IMapper mapper) : IRequestHandler<GetAllArticleRequest, IEnumerable<GetAllArticleResponse>>
{
    private readonly BlogDbContext _context = context;
    private readonly IMapper _mapper = mapper;

    public async Task<IEnumerable<GetAllArticleResponse>> Handle(GetAllArticleRequest request, CancellationToken cancellationToken)
    {
        return await _context.Articles
                .Select(a => new GetAllArticleResponse
                {
                    Slug = a.Slug,
                    Title = a.Title,
                    Tags = a.ArticleTags.Select(at => new TagDto
                    {
                        Id = at.Tag.Id,
                        Name = at.Tag.Name,
                    }).ToList(),
                    CreatedAt = a.CreatedAt.ToString("dd-MM-yyyy"),
                    UpdatedAt = a.UpdatedAt.ToString("dd-MM-yyyy"),
                })
            .ToListAsync(cancellationToken);
    }
}
