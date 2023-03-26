using FichasAndDragons.Comum.Configs.Interfaces;
using FichasAndDragons.Comum.Genericos;
using FichasAndDragons.Dominio.Personagens.Entidades;
using FichasAndDragons.Dominio.Personagens.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FichasAndDragons.Infra.Personagens
{
    public class PersonagensRepositorio : MongoRepositorio<Personagem>, IPersonagensRepositorio
    {
        public PersonagensRepositorio(IMongoDatabaseConfiguration mongoDataBaseConfiguration) : base(mongoDataBaseConfiguration, "personagens")
        {
        }
    }
}
