using Dapper;
using LibruaryApi.ModelsAll.Models;
using LibruaryApi.ModelsAll.ModelsTDO;
using LibruaryApi.Repositories.InterfaceRepository;
using Npgsql;

namespace LibruaryApi.Repositories.ClassRepository
{
    public class BooksRepository : IBooksRepository
    {
        public const string CONNECTINGSTRING = "Server=127.0.0.1;Port=5432;Database=LibruaryForApi;User Id=postgres;Password=dfrt43i0";

        public List<BookModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<BookModel> GetById()
        {
            string query = $"select * from ";
            using (NpgsqlConnection npgsqlConnection = new NpgsqlConnection(CONNECTINGSTRING))
            {
                return npgsqlConnection.Query<BookModel>(query).ToList();
            }
        
        }

        public string Post(BookModelTDO book)
        {
            throw new NotImplementedException();
        }
    }
}
