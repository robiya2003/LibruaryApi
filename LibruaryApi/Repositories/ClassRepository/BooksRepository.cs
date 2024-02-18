using Dapper;
using LibruaryApi.ModelsAll;
using LibruaryApi.ModelsAll.Models;
using LibruaryApi.ModelsAll.ModelsTDO;
using LibruaryApi.Repositories.InterfaceRepository;
using Npgsql;

namespace LibruaryApi.Repositories.ClassRepository
{
    public class BooksRepository : IBooksRepository
    {
        public const string CONNECTINGSTRING = "Server=127.0.0.1;Port=5432;Database=LibruaryForApi;User Id=postgres;Password=dfrt43i0";

        public string Delete(int id)
        {
            #region
            string query1 = $"delete from \"books\" where book_id=@id";
            string query2 = $"delete from \"books_authers\" where book_id=@id";
            using (NpgsqlConnection npgsqlConnection = new NpgsqlConnection(CONNECTINGSTRING))
            {
                npgsqlConnection.Execute(query2, new { id });
            }
            using (NpgsqlConnection npgsqlConnection = new NpgsqlConnection(CONNECTINGSTRING))
            {
                npgsqlConnection.Execute(query1, new { id });
            }

            return $"malumot ochirildi";
            #endregion
        }

        public List<Books_authersModel> GetBooks()
        {
            using (NpgsqlConnection npgsqlConnection = new NpgsqlConnection(CONNECTINGSTRING))
            {
                return npgsqlConnection.Query<Books_authersModel>("\r\nselect * from books_authers\r\ninner join authers using(auther_id)\r\ninner join books using(book_id)").ToList();
            }
        }

        public string Post(int authet_id, BookModelTDO book)
        {
            #region
            string query = $"insert into \"books\"(book_name,about1,price,department_id,shelf_id,shelf_floor_id,shelf_floor_serious_id) values" +
                $"(@book_name,@about1,@price,@department_id,@shelf_id,@shelf_floor_id,@shelf_floor_serious_id)";
            using (NpgsqlConnection npgsqlConnection = new NpgsqlConnection(CONNECTINGSTRING))
            {
                npgsqlConnection.Execute(query, book);
            }
            string query1 = "insert into books_authers(auther_id,book_id) values " +
                $"({authet_id},(select book_id from books where book_name='{book.book_name}'))";
            using (NpgsqlConnection npgsqlConnection = new NpgsqlConnection(CONNECTINGSTRING))
            {
                npgsqlConnection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand(query1, npgsqlConnection);
                cmd.ExecuteNonQuery();
                npgsqlConnection.Close();
            }
            return "malumot qoshildi";
            #endregion
        }
        public string Put(int book_id, int auther_id, BookModelTDO book)
        {
            string query = $"update \"books\"set book_name=@book_name,about,price,department_id,shelf_id,shelf_floor_id,shelf_floor_serious_id) values" +
                $"(,@about,@price,@department_id,@shelf_id,@shelf_floor_id,@shelf_floor_serious_id) " +
                    $"where book_id={book_id}";
            using (NpgsqlConnection npgsqlConnection = new NpgsqlConnection(CONNECTINGSTRING))
            {
                npgsqlConnection.Execute(query,book);
            }

            return $"{book_id} malumot o'zgartirildi";



        }
    }
}
