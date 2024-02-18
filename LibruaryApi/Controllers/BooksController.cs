using LibruaryApi.ModelsAll;
using LibruaryApi.ModelsAll.ModelsTDO;
using LibruaryApi.Repositories.InterfaceRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibruaryApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        IBooksRepository _booksRepository;
        public BooksController(IBooksRepository booksRepository)
        {
            _booksRepository = booksRepository;
        }
        [HttpPost]
        public string Get(int AutherId,BookModelTDO bookModelTDO)
        {
            return _booksRepository.Post(AutherId,bookModelTDO);
        }
        [HttpGet]
        public List<Books_authersModel> GetBooks()
        {
            return _booksRepository.GetBooks();
        }
        [HttpDelete]
        public string Delete(int bookId)
        {
            return _booksRepository.Delete(bookId);
        }

    }
}
