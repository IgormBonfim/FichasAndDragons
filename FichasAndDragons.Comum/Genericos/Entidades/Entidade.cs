using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FichasAndDragons.Comum.Genericos.Entidades
{
    public class Entidade
    {
        public ObjectId Id { get; protected set; }

        public Entidade()
        {
        }
    }
}
