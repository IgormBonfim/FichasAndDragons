using AutoMapper;
using FichasAndDragons.Comum.Genericos.Entidades;
using FichasAndDragons.DataTransfer.Genericos.Responses;

namespace FichasAndDragons.Aplicacao.Genericos.Profiles
{
    public class PaginacaoProfile : Profile
    {
        public PaginacaoProfile()
        {
            CreateMap(typeof(Paginacao<>), typeof(PaginacaoResponse<>));
        }
    }
}
