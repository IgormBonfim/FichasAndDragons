using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FichasAndDragons.Dominio.Genericos.Entidades;
using MongoDB.Bson;

namespace FichasAndDragons.Dominio.Genericos.Interfaces
{
    public interface IMongoRepositorio<T> where T : Entidade
    {
        T Adicionar(T entidade);
        T Atualizar(ObjectId id, T entidade);
        IEnumerable<T> Listar();
        Paginacao<T> Listar(IQueryable<T> query, int pagina, int quantidade);
        IQueryable<T> Query();
        T Recuperar(ObjectId id);
        void Excluir(ObjectId id);
    }
}
