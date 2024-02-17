using LibruaryApi.ModelsAll.Models;
using LibruaryApi.ModelsAll.ModelsTDO;

namespace LibruaryApi.Repositories.InterfaceRepository
{
    public interface IDepartmentsRepository
    {
        public List<DepartmentModel> Get();
        public string Delete(int id);
        public string Post(DeparmentModelTDO department);
        public string Put(int id,DeparmentModelTDO department);
    }
}
