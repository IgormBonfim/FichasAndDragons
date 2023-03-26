using FichasAndDragons.Dominio.Genericos.Interfaces;
using FichasAndDragons.Dominio.Personagens.Entidades;
using FichasAndDragons.Dominio.Personagens.Repositorios;
using FichasAndDragons.Infra.Configs.Interfaces;
using FichasAndDragons.Infra.Genericos;
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
