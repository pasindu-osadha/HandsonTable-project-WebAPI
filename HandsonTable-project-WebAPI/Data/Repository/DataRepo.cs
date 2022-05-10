using HandsonTable_project_WebAPI.Data.Interface;
using HandsonTable_project_WebAPI.Dtos;
using HandsonTable_project_WebAPI.Models;

namespace HandsonTable_project_WebAPI.Data.Repository
{
    public class DataRepo : IDataRepo
    {
        private readonly HandsonTableDbContext _context;

        public DataRepo(HandsonTableDbContext context)
        {
            _context = context;
        }
        public List<HandsontableDataModel> getAllData()
        {
            return _context.HandsontableDataModels.ToList();

        }

        public List<HandsontableDataModel> getPageData(PageDataRequestDto pagedataRrequestDto)
        {
            var resultFromDB = _context.HandsontableDataModels.ToList();

            var startIndex = (pagedataRrequestDto.pageNo - 1) * pagedataRrequestDto.numberOfDataInPage;
            var endIndex = (resultFromDB.Count< (startIndex+pagedataRrequestDto.numberOfDataInPage) )?resultFromDB.Count : (startIndex + pagedataRrequestDto.numberOfDataInPage);

            List<HandsontableDataModel> resultTable = new List<HandsontableDataModel>();
            for (int i = startIndex; i < endIndex; i++)
            {
                resultTable.Add(resultFromDB[i]);
            }
            return resultTable;
        }

        public bool updateRawData(List<HandsontableDataModel> handsontableDataModels)
        {
            for(int i = 0;i< handsontableDataModels.Count; i++)
            {
                _context.Update(handsontableDataModels[i]);
                _context.SaveChanges();
            }
            return true; 
        }

        public bool chackbeforeSave()
        {
            var data = _context.HandsontableDataModels.ToList();
            
            for(int i =0; i < data.Count; i++)
            {
                double skillSum = 0; 
                double capacitySum = 0;
                HandsontableDataModel handsontableData = data[i];
                skillSum = handsontableData.skill1 + handsontableData.skill2+ handsontableData.skill3;

                if (skillSum != 1)
                {
                    return false;
                }

                capacitySum = handsontableData.capacity1 + handsontableData.capacity2 + handsontableData.capacity3 + handsontableData.capacity4;
            
                if(capacitySum != 1)
                {
                    return false;
                }
            }
            
            
            return true; 
        }
    }
}
