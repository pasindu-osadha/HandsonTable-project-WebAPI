using HandsonTable_project_WebAPI.Dtos;
using HandsonTable_project_WebAPI.Models;

namespace HandsonTable_project_WebAPI.Data.Interface
{
    public interface IDataRepo
    {
        List<HandsontableDataModel> getAllData();
        List<HandsontableDataModel> getPageData(PageDataRequestDto pagedataRrequestDto);
        bool updateRawData(List<HandsontableDataModel> handsontableDataModels);
    }
}
