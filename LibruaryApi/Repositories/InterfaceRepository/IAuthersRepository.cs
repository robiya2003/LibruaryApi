using LibruaryApi.ModelsAll.Models;
using LibruaryApi.ModelsAll.ModelsTDO;

namespace LibruaryApi.Repositories.InterfaceRepository
{
    public interface IAuthersRepository
    {
        public List<AutherModel> GetAuthers();
        public AutherModel GetAuther(int id);
        public string Post(AutherModelTDO autherModelTDO);
        public string Put(int id,AutherModelTDO autherModelTDO);
        public string Delete(int id);

    }
}
