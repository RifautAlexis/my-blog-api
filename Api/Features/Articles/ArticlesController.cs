using Api.Features.Articles.GetAllArticle;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;

namespace Api.Features.Articles;
[Route("api/[controller]")]
[ApiController]
public class ArticlesController : ControllerBase
{
    private readonly IMediator _mediator;

    public ArticlesController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet("")]
    public async Task<ActionResult<GetAllArticleResponse>> GetAllArticle()
    {
        var request = new GetAllArticleRequest();

        var response = await _mediator.Send(request);
        return Ok(response);
    }
}
