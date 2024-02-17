using LibruaryApi.ModelsAll.Models;
using LibruaryApi.Repositories.InterfaceRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibruaryApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class libruary_floorController : ControllerBase
    {

        public ILibruary_FloorRepository _libruary_FloorRepository;
        public libruary_floorController(ILibruary_FloorRepository libruary_FloorRepository)
        {
            _libruary_FloorRepository = libruary_FloorRepository;
        }
        [HttpPost]
        public string Post(Libruary_floorModel model)
        {
            
            return _libruary_FloorRepository.Post(model);
        }
        [HttpGet]
        public List<Libruary_floorModel> Get()
        {
            return _libruary_FloorRepository.GetAll();
        }
        [HttpDelete]
        public string Delete(Libruary_floorModel model)
        {
            return _libruary_FloorRepository.Delete(model);
        }
    }
}
