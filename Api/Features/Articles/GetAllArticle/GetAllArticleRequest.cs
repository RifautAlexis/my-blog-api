using MediatR;

namespace Api.Features.Articles.GetAllArticle;
public class GetAllArticleRequest : IRequest<IEnumerable<GetAllArticleResponse>>
{
}
