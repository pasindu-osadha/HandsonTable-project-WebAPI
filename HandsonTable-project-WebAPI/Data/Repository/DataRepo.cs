using HandsonTable_project_WebAPI.Data.Interface;
using HandsonTable_project_WebAPI.Models;

namespace HandsonTable_project_WebAPI.Data.Repository
{
    public class DataRepo : IDataRepo
    {
        private readonly HandsonTableDbContext _context;

        public DataRepo(HandsonTableDbContext context)
        {
            _context= context;
        }
        public List<HandsontableDataModel> getAllData()
        {
            return _context.HandsontableDataModels.ToList();
            
        }
    }
}
