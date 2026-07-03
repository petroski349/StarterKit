using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    /// <summary>
    /// Obtém todos os usuários.
    /// </summary>
    /// <response code="200">Lista de usuários.</response>
    /// <response code="500">Erro interno do servidor.</response>
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    [EndpointSummary("Obtém todos os usuários")]
    [EndpointDescription("Retorna uma lista contendo todos os usuários ativos cadastrados.")]
    public IActionResult GetUsers()
    {
        return Ok("Projeto funcionando!");
    }

    /// <summary>
    /// Obtém todos os usuários.
    /// </summary>
    /// <response code="200">Lista de usuários.</response>
    /// <response code="500">Erro interno do servidor.</response>    
    [HttpGet("teste-badrequest")]
    public IActionResult GetBadRequest()
    {
        return BadRequest(new ProblemDetails
        {
            Title = "Dados inválidos.",
            Detail = "O e-mail informado é inválido.",
        });
    }
    [HttpGet("teste-OK")]
    public IActionResult GetSucces()
    {
        return Ok("Sucesso");
    }

}