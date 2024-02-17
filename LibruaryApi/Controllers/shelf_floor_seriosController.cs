using LibruaryApi.ModelsAll.Models;
using LibruaryApi.Repositories.InterfaceRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibruaryApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class shelf_floor_seriosController : ControllerBase
    {
        public IShelf_floor_seriousRepository _shelf_Floor_SeriousRepository;
        public shelf_floor_seriosController(IShelf_floor_seriousRepository shelf_Floor_SeriousRepository)
        {
            _shelf_Floor_SeriousRepository = shelf_Floor_SeriousRepository;
        }
        [HttpGet]
        public List<shelf_floor_seriousModel> Get()
        {
            return _shelf_Floor_SeriousRepository.GetAll();
        }
    }
}
