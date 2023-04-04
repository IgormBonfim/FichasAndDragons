using FichasAndDragons.Comum.Genericos.Entidades;
using FichasAndDragons.Comum.Genericos.Interfaces;
using FichasAndDragons.Comum.Configs.Interfaces;
using MongoDB.Bson;
using MongoDB.Driver;

namespace FichasAndDragons.Comum.Genericos
{
    public class MongoRepositorio<T> : IMongoRepositorio<T> where T : Entidade
    {
        private readonly IMongoCollection<T> mongoCollection;

        public MongoRepositorio(IMongoDatabaseConfiguration mongoDataBaseConfiguration, string collection)
        {
            mongoCollection = mongoDataBaseConfiguration.MongoDatabase.GetCollection<T>(collection);
        }

        public T Adicionar(T entidade)
        {
            Console.WriteLine(entidade);
            Console.WriteLine(mongoCollection);

            mongoCollection.InsertOne(entidade);
            return entidade;
        }

        public T Atualizar(ObjectId id, T entidade)
        {
            mongoCollection.ReplaceOne(entidade => entidade.Id == id, entidade);
            return entidade;
        }

        public void Excluir(ObjectId id)
        {
            mongoCollection.DeleteOne(entidade => entidade.Id == id);
        }

        public IEnumerable<T> Listar()
        {
            return mongoCollection.Find(entidade => true).ToList();
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
                Total = total,
                Pagina = pagina,
                Quantidade = quantidade,
                Registros = items,
            };
        }

        private IQueryable<T> Paginar(IQueryable<T> query, int pagina, int quantidade)
        {
            int pular = (pagina * quantidade) - quantidade;

            return query.Skip(pular).Take(quantidade);
        }

        public T Recuperar(ObjectId id)
        {
            return mongoCollection.Find(entidade => entidade.Id == id).FirstOrDefault();
        }

        public IQueryable<T> Query()
        {
            return mongoCollection.AsQueryable();
        }
    }
}
