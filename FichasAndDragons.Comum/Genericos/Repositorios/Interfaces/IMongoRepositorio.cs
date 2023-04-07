using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using FichasAndDragons.Comum.Genericos.Entidades;
using MongoDB.Bson;

namespace FichasAndDragons.Comum.Genericos.Interfaces
{
    public interface IMongoRepositorio<T> where T : Entidade
    {
        T Adicionar(T entidade);
        T Atualizar(ObjectId id, T entidade);
        IEnumerable<T> Listar();
        IEnumerable<T> Listar(Expression<Func<T, bool>> filtro);
        Paginacao<T> Listar(IQueryable<T> query, int pagina, int quantidade);
        IQueryable<T> Query();
        T Recuperar(ObjectId id);
        void Excluir(ObjectId id);
    }
}
