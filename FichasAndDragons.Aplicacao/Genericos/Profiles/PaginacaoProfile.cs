using AutoMapper;
using FichasAndDragons.DataTransfer.Genericos.Responses;
using FichasAndDragons.Dominio.Genericos.Entidades;

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
