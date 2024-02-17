using LibruaryApi.ModelsAll.Models;
using LibruaryApi.ModelsAll.ModelsTDO;

namespace LibruaryApi.Repositories.InterfaceRepository
{
    public interface IBooksRepository
    {
        public List<BookModel> GetAll();
        public string Post(BookModelTDO book);
    }
}
