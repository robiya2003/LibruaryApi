using Dapper;
using LibruaryApi.ModelsAll.Models;
using LibruaryApi.ModelsAll.ModelsTDO;
using LibruaryApi.Repositories.InterfaceRepository;
using Npgsql;

namespace LibruaryApi.Repositories.ClassRepository
{
    public class DepartmentsRepository : IDepartmentsRepository
    {
        public const string CONNECTINGSTRING = "Server=127.0.0.1;Port=5432;Database=LibruaryForApi;User Id=postgres;Password=dfrt43i0";
        public string Delete(int id)
        {
            string query = $"delete from \"Departments\" where department_id=@id";
            using (NpgsqlConnection npgsqlConnection = new NpgsqlConnection(CONNECTINGSTRING))
            {
                npgsqlConnection.Execute(query, new {id});
            }

            return $"malumot ochirildi";
        }

        public List<DepartmentModel> Get()
        {
            using (NpgsqlConnection npgsqlConnection = new NpgsqlConnection(CONNECTINGSTRING))
            {
                return npgsqlConnection.Query<DepartmentModel>("select * from \"Departments\"").ToList();
            }
        }

        public string Post(DeparmentModelTDO department)
        {
            string query = $"insert into \"Departments\"(department_name,floor_number) values" +
                $"(@department_name,@floor_number)";
            using (NpgsqlConnection npgsqlConnection = new NpgsqlConnection(CONNECTINGSTRING))
            {
                npgsqlConnection.Execute(query, department);
            }

            return "malumot qoshildi";
        }

        public string Put(int id, DeparmentModelTDO department)
        {
            string query = $"update \"Departments\" set department_name=@department_name,floor_number=@floor_number " +
                $"where department_id={id}";
            using (NpgsqlConnection npgsqlConnection = new NpgsqlConnection(CONNECTINGSTRING))
            {
                npgsqlConnection.Execute(query, department);
            }

            return $"{id} malumot o'zgartirildi";
        }
    }
}
