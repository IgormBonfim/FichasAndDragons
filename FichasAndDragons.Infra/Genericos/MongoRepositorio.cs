using MongoDB.Driver;
using FichasAndDragons.Dominio.Genericos.Entidades;
using FichasAndDragons.Dominio.Genericos.Interfaces;
using FichasAndDragons.Infra.Configs.Interfaces;

namespace FichasAndDragons.Infra.Genericos
{
    public class MongoRepositorio<T> : IMongoRepositorio<T> where T : Entidade
    {
        private readonly IMongoCollection<T> _mongoCollection;

        public MongoRepositorio(IMongoDatabaseConfiguration mongoDataBaseConfiguration, string collection)
        {
            _mongoCollection = mongoDataBaseConfiguration.MongoDatabase.GetCollection<T>(collection);
        }

        public T Adicionar(T entidade)
        {
            _mongoCollection.InsertOne(entidade);
            return entidade;
        }

        public T Atualizar(string id, T entidade)
        {
            _mongoCollection.ReplaceOne(entidade => entidade.Id == id, entidade);
            return entidade;
        }

        public void Excluir(string id)
        {
            _mongoCollection.DeleteOne(entidade => entidade.Id == id);
        }

        public IEnumerable<T> Listar()
        {
            return _mongoCollection.Find(entidade => true).ToList();
        }

        public Paginacao<T> Listar(IQueryable<T> query, int pagina, int quantidade)
        {
            int total = query.Count();
            query = Paginar(query, pagina, quantidade);

            return ListarPaginado(query, pagina, quantidade, total);
        }

        private Paginacao<T> ListarPaginado(IQueryable<T> query, int pagina, int quantidade, int total)
        {
            List<T> items = query.ToList();

            return new Paginacao<T>
            {
                TotalItems = total,
                Pagina = pagina,
                Quantidade = quantidade,
                Lista = items,
            };
        }

        private IQueryable<T> Paginar(IQueryable<T> query, int pagina, int quantidade)
        {
            int pular = (pagina * quantidade) - quantidade;

            return query.Skip(pular).Take(quantidade);
        }

        public T Recuperar(string id)
        {
            return _mongoCollection.Find(entidade => entidade.Id == id).FirstOrDefault();
        }

        public IQueryable<T> Query()
        {
            return _mongoCollection.AsQueryable();
        }
    }
}
