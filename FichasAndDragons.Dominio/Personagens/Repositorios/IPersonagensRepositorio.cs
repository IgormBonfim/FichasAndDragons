using FichasAndDragons.Dominio.Genericos.Interfaces;
using FichasAndDragons.Dominio.Personagens.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FichasAndDragons.Dominio.Personagens.Repositorios
{
    public interface IPersonagensRepositorio : IMongoRepositorio<Personagem>
    {
    }
}
