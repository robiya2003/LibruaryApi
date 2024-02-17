using LibruaryApi.ModelsAll.Models;

namespace LibruaryApi.Repositories.InterfaceRepository
{
    public interface ILibruary_FloorRepository
    {
        public List<Libruary_floorModel> GetAll();
        public string Delete(Libruary_floorModel model);
        public string Post(Libruary_floorModel model);
    }
}
