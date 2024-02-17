using LibruaryApi.ModelsAll.Models;
using LibruaryApi.ModelsAll.ModelsTDO;
using LibruaryApi.Repositories.InterfaceRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibruaryApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {
        public IDepartmentsRepository _departmentsRepository { get; set; }
        public DepartmentsController(IDepartmentsRepository departmentsRepository)
        {
            _departmentsRepository = departmentsRepository;
        }
        [HttpGet]
        public List<DepartmentModel> Get()
        {
            return _departmentsRepository.Get();
        }
        [HttpPost]
        public string Post(DeparmentModelTDO deparmentModelTDO)
        {
            return _departmentsRepository.Post(deparmentModelTDO);
        }
        [HttpDelete]
        public string Delete(int id)
        {
            return _departmentsRepository.Delete(id);
        }
        [HttpPut]
        public string Put(int id,DeparmentModelTDO model)
        {
            return _departmentsRepository.Put(id, model);
        }
    }
}
