using Dapper;
using LibruaryApi.ModelsAll;
using LibruaryApi.ModelsAll.Models;
using LibruaryApi.ModelsAll.ModelsTDO;
using LibruaryApi.Repositories.InterfaceRepository;
using Npgsql;

namespace LibruaryApi.Repositories.ClassRepository
{
    public class ShelfsRepository : IShelfsRepository
    {
        public const string CONNECTINGSTRING = "Server=127.0.0.1;Port=5432;Database=LibruaryForApi;User Id=postgres;Password=dfrt43i0";
        public string Delete(int shelfId)
        {
            string query = $"delete from \"shelf\" where shelf_id=@shelfId";
            using (NpgsqlConnection npgsqlConnection = new NpgsqlConnection(CONNECTINGSTRING))
            {
                npgsqlConnection.Execute(query,new { shelfId });
            }

            return $"{shelfId}-chi malumot ochirildi";
        }

        public List<ShelfModel> GetShelfByDepartmentId(int id)
        {
            using (NpgsqlConnection npgsqlConnection = new NpgsqlConnection(CONNECTINGSTRING))
            {
                return npgsqlConnection.Query<ShelfModel>($"select * from \"shelf\" where department_id={id}").ToList();
            }
        }

        public string GetShelfById(int shelfId)
        {
            using (NpgsqlConnection npgsqlConnection = new NpgsqlConnection(CONNECTINGSTRING))
            {
                var dept_list= npgsqlConnection.Query <ShelfDepartment>($"select department_name,shelf_id from shelf\r\ninner join \"Departments\" using(department_id)\r\nwhere shelf_id={shelfId}").ToList();
                return $"{dept_list[0].Department_name} bolimga qarashli";
            }
            
        }

        public List<ShelfDepartment> GetShelfModels()
        {
            using (NpgsqlConnection npgsqlConnection = new NpgsqlConnection(CONNECTINGSTRING))
            {
                return npgsqlConnection.Query<ShelfDepartment>("select department_name,shelf_id from shelf\r\ninner join \"Departments\" using(department_id)\r\norder by shelf_id").ToList();
            }
        }

        public string Post(ShelfModelTDO shelf)
        {
            string query = $"insert into \"shelf\"(department_id) values" +
                $"(@department_id)";
            using (NpgsqlConnection npgsqlConnection = new NpgsqlConnection(CONNECTINGSTRING))
            {
                npgsqlConnection.Execute(query, shelf);
            }

            return "malumot qoshildi";
        }

        public string Put(int shelfId, ShelfModelTDO shelfModelTDO)
        {
            string query = $"update \"shelf\" set department_id=@department_id " +
                $"where shelf_id={shelfId}";
            using (NpgsqlConnection npgsqlConnection = new NpgsqlConnection(CONNECTINGSTRING))
            {
                npgsqlConnection.Execute(query,shelfModelTDO);
            }

            return $"{shelfId} malumot o'zgartirildi";
        }
    }
}
