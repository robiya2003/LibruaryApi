using Dapper;
using LibruaryApi.ModelsAll;
using LibruaryApi.ModelsAll.Models;
using LibruaryApi.ModelsAll.ModelsTDO;
using LibruaryApi.Repositories.InterfaceRepository;
using Npgsql;

namespace LibruaryApi.Repositories.ClassRepository
{
    public class Shelf_floorsRepository : IShelf_floorsRepository
    {
        public const string CONNECTINGSTRING = "Server=127.0.0.1;Port=5432;Database=LibruaryForApi;User Id=postgres;Password=dfrt43i0";
        public string Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<shelf_floorModel> GetAll()
        {
            using (NpgsqlConnection npgsqlConnection = new NpgsqlConnection(CONNECTINGSTRING))
            {
                return npgsqlConnection.Query<shelf_floorModel>("select * from \"shelf_floor\"").ToList();
            }
        }

        public string Post(int id)
        {
            throw new NotImplementedException();
        }

        public string Put(int id)
        {
            throw new NotImplementedException();
        }
    }
}
