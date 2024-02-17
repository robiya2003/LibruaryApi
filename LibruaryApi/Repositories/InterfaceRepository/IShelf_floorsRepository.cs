using LibruaryApi.ModelsAll.Models;

namespace LibruaryApi.Repositories.InterfaceRepository
{
    public interface IShelf_floorsRepository
    {
        public List<shelf_floorModel> GetAll();
        public string Delete(int id);
        public string Put(int id);
        public string Post(int id);
    }
}
