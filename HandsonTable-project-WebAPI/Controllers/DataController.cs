using HandsonTable_project_WebAPI.Data.Interface;
using HandsonTable_project_WebAPI.Dtos;
using HandsonTable_project_WebAPI.Models;
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

        [HttpPost]
        [Route("getdataAtPage")]
        public ActionResult getPageData(PageDataRequestDto pageDataRequestDto)
        {
            var tableData = _repo.getPageData(pageDataRequestDto);
            return Ok(tableData);
        }

        [HttpPut]
        [Route("updateRows")]
        public ActionResult updateRows(List<HandsontableDataModel> handsontableDataModels)
        {
            if (_repo.updateRawData(handsontableDataModels))
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPost]
        [Route("chackbeforeSave")]
        public ActionResult chackbeforeSave()
        {
            return Ok(); 
        }
    }
}
