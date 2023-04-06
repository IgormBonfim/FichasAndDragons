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

        [HttpPost]
        public ActionResult<PersonagemResponse> Adicionar([FromBody] PersonagemInserirRequest request)
        {
            var response = personagensAppServico.Adicionar(request);
            return Created($"/{response.Id}", response);
        }

        [HttpGet("{id}")]
        public ActionResult<PersonagemResponse> Recuperar(string id)
        {
            var response = personagensAppServico.Recuperar(id);
            return Ok(response);
        }
    }
}
