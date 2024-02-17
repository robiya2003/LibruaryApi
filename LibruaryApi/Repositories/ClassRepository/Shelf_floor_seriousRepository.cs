using Dapper;
using LibruaryApi.ModelsAll.Models;
using LibruaryApi.Repositories.InterfaceRepository;
using Npgsql;

namespace LibruaryApi.Repositories.ClassRepository
{
    public class Shelf_floor_seriousRepository : IShelf_floor_seriousRepository

    {
        public const string CONNECTINGSTRING = "Server=127.0.0.1;Port=5432;Database=LibruaryForApi;User Id=postgres;Password=dfrt43i0";
        public List<shelf_floor_seriousModel> GetAll()
        {
            using (NpgsqlConnection npgsqlConnection = new NpgsqlConnection(CONNECTINGSTRING))
            {
                return npgsqlConnection.Query<shelf_floor_seriousModel>("select * from \"shelf_floor_serious\"").ToList();
            }
        }
    }
}
