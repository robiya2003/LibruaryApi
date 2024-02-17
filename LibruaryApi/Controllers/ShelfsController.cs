using LibruaryApi.ModelsAll;
using LibruaryApi.ModelsAll.Models;
using LibruaryApi.ModelsAll.ModelsTDO;
using LibruaryApi.Repositories.InterfaceRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibruaryApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ShelfsController : ControllerBase
    {
        public IShelfsRepository _shelfsRepository;
        public ShelfsController(IShelfsRepository shelfsRepository)
        {
            _shelfsRepository = shelfsRepository;
        }
        [HttpPost]
        public string Post(ShelfModelTDO shelfModelTDO)
        {
            return _shelfsRepository.Post(shelfModelTDO);
        }
        [HttpDelete] 
        public string Delete(int id)
        {
            return _shelfsRepository.Delete(id);
        }
        [HttpPut]
        public string Put(int id,ShelfModelTDO modelTDO)
        {
            return _shelfsRepository.Put(id, modelTDO);
        }
        [HttpGet]
        public List<ShelfDepartment> GetAllshelfs()
        {
            return _shelfsRepository.GetShelfModels();
        }

        [HttpGet]
        public string GetShelfById(int id)
        {
            return _shelfsRepository.GetShelfById(id);
        }
        [HttpGet]
        public List<ShelfModel> GetShelfByDepartmentId(int id)
        {
            return _shelfsRepository.GetShelfByDepartmentId(id);
        }
    }
}
