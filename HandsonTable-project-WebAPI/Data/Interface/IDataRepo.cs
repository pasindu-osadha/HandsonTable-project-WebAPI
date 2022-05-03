using HandsonTable_project_WebAPI.Models;

namespace HandsonTable_project_WebAPI.Data.Interface
{
    public interface IDataRepo
    {
        List<HandsontableDataModel> getAllData();
    }
}
