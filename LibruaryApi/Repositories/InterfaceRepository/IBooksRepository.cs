using LibruaryApi.ModelsAll;
using LibruaryApi.ModelsAll.Models;
using LibruaryApi.ModelsAll.ModelsTDO;

namespace LibruaryApi.Repositories.InterfaceRepository
{
    public interface IBooksRepository
    {
        public string Post(int authet_id,BookModelTDO book);
        public List<Books_authersModel> GetBooks();
        public string Delete(int id);
        public string Put(int book_id, int auther_id, BookModelTDO book);

    }
}
