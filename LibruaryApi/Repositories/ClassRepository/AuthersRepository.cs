using Dapper;
using LibruaryApi.ModelsAll.Models;
using LibruaryApi.ModelsAll.ModelsTDO;
using LibruaryApi.Repositories.InterfaceRepository;
using Npgsql;

namespace LibruaryApi.Repositories.ClassRepository
{
    public class AuthersRepository : IAuthersRepository
    {
        public const string CONNECTINGSTRING = "Server=127.0.0.1;Port=5432;Database=LibruaryForApi;User Id=postgres;Password=dfrt43i0";
        public string Delete(int id)
        {
            string query = $"delete from \"authers\" where auther_id=@id";
            using (NpgsqlConnection npgsqlConnection = new NpgsqlConnection(CONNECTINGSTRING))
            {
                npgsqlConnection.Execute(query, new { id });
            }

            return $"malumot ochirildi";
        }

        public AutherModel GetAuther(int id)
        {
            using (NpgsqlConnection npgsqlConnection = new NpgsqlConnection(CONNECTINGSTRING))
            {
                var l= npgsqlConnection.Query<AutherModel>("select * from \"authers\"").ToList();
                return l[0];
            }
        }

        public List<AutherModel> GetAuthers()
        {
            using (NpgsqlConnection npgsqlConnection = new NpgsqlConnection(CONNECTINGSTRING))
            {
                return npgsqlConnection.Query<AutherModel>("select * from \"authers\"").ToList();
            }
        }

        public string Post(AutherModelTDO autherModelTDO)
        {
            string query = $"insert into \"authers\"(fullname,about) values" +
                $"(@fullname,@about)";
            using (NpgsqlConnection npgsqlConnection = new NpgsqlConnection(CONNECTINGSTRING))
            {
                npgsqlConnection.Execute(query, autherModelTDO);
            }

            return "malumot qoshildi";
        }

        public string Put(int id, AutherModelTDO autherModelTDO)
        {
            string query = $"update \"authers\" set fullname=@fullname,about=@about " +
                $"where auther_id={id}";
            using (NpgsqlConnection npgsqlConnection = new NpgsqlConnection(CONNECTINGSTRING))
            {
                npgsqlConnection.Execute(query, autherModelTDO);
            }

            return $"{id} malumot o'zgartirildi";
        }
    }
}
