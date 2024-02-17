using LibruaryApi.ModelsAll;
using LibruaryApi.ModelsAll.Models;
using LibruaryApi.ModelsAll.ModelsTDO;

namespace LibruaryApi.Repositories.InterfaceRepository
{
    public interface IShelfsRepository
    {
        // hamma shkaflarni 
        public List<ShelfDepartment> GetShelfModels();
        //berilgan id boyicha shakf qaysi bolimga qarashini
        public string GetShelfById(int shelfId);
        // bolim boyicah shkaflarni listini
        public List<ShelfModel> GetShelfByDepartmentId(int id);



        public string Post(ShelfModelTDO shelf);
        public string Delete(int shelfId);
        public string Put(int shelfId,ShelfModelTDO shelfModelTDO);
    }
}
