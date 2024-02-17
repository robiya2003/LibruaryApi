using Dapper;
using LibruaryApi.ModelsAll.Models;
using LibruaryApi.Repositories.InterfaceRepository;
using Npgsql;

namespace LibruaryApi.Repositories.ClassRepository
{
    public class Libruary_FloorRepository : ILibruary_FloorRepository
    {
        public const string CONNECTINGSTRING = "Server=127.0.0.1;Port=5432;Database=LibruaryForApi;User Id=postgres;Password=dfrt43i0";
        public string Delete(Libruary_floorModel libruary_FloorModel)
        {
            string query = $"delete from libruary_floor where floor_number=@floor_number";
            using (NpgsqlConnection npgsqlConnection = new NpgsqlConnection(CONNECTINGSTRING))
            {
                npgsqlConnection.Execute(query, libruary_FloorModel);
            }

            return "malumot ochirildi";
        }

        public List<Libruary_floorModel> GetAll()
        {
            using (NpgsqlConnection npgsqlConnection = new NpgsqlConnection(CONNECTINGSTRING))
            {
                return npgsqlConnection.Query<Libruary_floorModel>("select * from libruary_floor").ToList();
            }
        }

        public string Post(Libruary_floorModel libruary_FloorModel)
        {
            string query = $"insert into libruary_floor(floor_number) values" +
                $"(@floor_number)";
            using (NpgsqlConnection npgsqlConnection = new NpgsqlConnection(CONNECTINGSTRING))
            {
                npgsqlConnection.Execute(query, libruary_FloorModel);
            }
            return "malumot qoshildi";
        }
    }
}
