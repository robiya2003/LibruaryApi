using LibruaryApi.ModelsAll.Models;
using LibruaryApi.Repositories.InterfaceRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibruaryApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class Shelf_floorsController : ControllerBase
    {
        IShelf_floorsRepository _shelf_FloorsRepository { get; set; }
        public Shelf_floorsController(IShelf_floorsRepository shelf_FloorsRepository)
        {
            _shelf_FloorsRepository = shelf_FloorsRepository;
        }
        [HttpGet]
        public List<shelf_floorModel> Get()
        {
            return _shelf_FloorsRepository.GetAll();
        }
    }
}
