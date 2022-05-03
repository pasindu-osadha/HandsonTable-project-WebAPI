using HandsonTable_project_WebAPI.Data.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HandsonTable_project_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataController : ControllerBase
    {
        private readonly IDataRepo _repo;

        public DataController(IDataRepo repo)
        {
            _repo = repo;
        }


        [HttpGet]
        [Route("getAllData")]
        public ActionResult getAllData()
        {
            
            return Ok(_repo.getAllData());
        }
    }
}
