using MediatR;

namespace Api.Features.Articles.GetAllArticle;

public class GetAllArticleHandler : IRequestHandler<GetAllArticleRequest, GetAllArticleResponse>
{
    public Task<GetAllArticleResponse> Handle(GetAllArticleRequest request, CancellationToken cancellationToken)
    {
        return Task.FromResult(
            new GetAllArticleResponse
            {
                Title = "This is a title",
            }
        );
    }
}
