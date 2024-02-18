using LibruaryApi.ModelsAll.Models;
using LibruaryApi.ModelsAll.ModelsTDO;
using LibruaryApi.Repositories.InterfaceRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibruaryApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AuthersController : ControllerBase
    {
        IAuthersRepository _authersRepository;
        public AuthersController(IAuthersRepository authersRepository)
        {
            _authersRepository = authersRepository;
        }
        [HttpPost]
        public string Post(AutherModelTDO auther)
        {
            return _authersRepository.Post(auther);
        }
        [HttpGet]
        public List<AutherModel> GetAll()
        {
            return _authersRepository.GetAuthers();
        }
        [HttpGet]
        public AutherModel GetById(int id)
        {
            return _authersRepository.GetAuther(id);
        }
        [HttpDelete]
        public string DeleteById(int id)
        {
            return _authersRepository.Delete(id);
        }
        [HttpPut]
        public string Put(int id,AutherModelTDO autherModelTDO)
        {
            return _authersRepository.Put(id,autherModelTDO);
        }
    }
}
