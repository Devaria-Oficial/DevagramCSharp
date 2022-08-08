using DevagramCSharp.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DevagramCSharp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoginController : ControllerBase
    {

        private readonly ILogger<LoginController> _logger;

        public LoginController (ILogger<LoginController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        [AllowAnonymous]
        public IActionResult EfetuarLogin([FromBody] LoginRequisicaoDto loginrequisicao)
        {
            try
            {
                throw new ArgumentException("Erro ao preencher os dados");
            }
            catch (Exception e)
            {
                _logger.LogError("Ocorreu um erro no login: " + e.Message);
                return StatusCode(StatusCodes.Status500InternalServerError, new ErrorRespostaDto()
                {
                    Descricao = "Ocorreu um erro ao fazer o login",
                    Status = StatusCodes.Status500InternalServerError
                });
            }
        }


    }
}
