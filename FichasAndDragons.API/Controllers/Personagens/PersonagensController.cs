using FichasAndDragons.Aplicacao.Personagens.Servicos.Interfaces;
using FichasAndDragons.DataTransfer.Personagens.Requests;
using FichasAndDragons.DataTransfer.Personagens.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FichasAndDragons.API.Controllers.Personagens
{
    [Route("api/personagens")]
    [ApiController]
    public class PersonagensController : ControllerBase
    {
        private readonly IPersonagensAppServico personagensAppServico;

        public PersonagensController(IPersonagensAppServico personagensAppServico)
        {
            this.personagensAppServico = personagensAppServico;
        }

        [HttpGet]
        public ActionResult<IEnumerable<PersonagemResponse>> Listar([FromQuery] PersonagemListarRequest request)
        {
            var response = personagensAppServico.Listar(request);
            return Ok(response);
        }

        [HttpGet("{id}")]
        public ActionResult<PersonagemResponse> Recuperar(string id)
        {
            var response = personagensAppServico.Recuperar(id);
            return Ok(response);
        }

        [HttpPost]
        public ActionResult<PersonagemResponse> Adicionar([FromBody] PersonagemInserirRequest request)
        {
            var response = personagensAppServico.Adicionar(request);
            return Created($"/{response.Id}", response);
        }

        [HttpPut("{id}")]
        public ActionResult<PersonagemResponse> Editar([FromRoute] string id, [FromBody] PersonagemInserirRequest request)
        {
            var response = personagensAppServico.Editar(request, id);
            return Ok(response);
        }

        [HttpPatch("{id}")]
        public ActionResult<bool> MudarInspiracao([FromRoute] string id)
        {
            var response = personagensAppServico.MudarInspiracao(id);
            return Ok(response);
        }
    }
}
