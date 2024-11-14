using Api.Entities;
using Api.Features.Articles.GetAllArticle;
using AutoMapper;

namespace Api.Features.Articles;

public class ArticleProfile : Profile
{
    public ArticleProfile()
    {
        CreateMap<Article, GetAllArticleResponse>();
    }
}
