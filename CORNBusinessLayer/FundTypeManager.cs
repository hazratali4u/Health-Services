using CORNDataAccessLayer.Request;
using CORNDataAccessLayer.Response;
using CORNDatabaseLayer;

namespace CORNBusinessLayer
{
    public class FundTypeManager
    {
        public FundTypeResponse FundTypeGetAll()
        {
            FundTypeDataAccess dataAccess = new FundTypeDataAccess();

            return dataAccess.FundTypeGetAll();
        }
        public FundTypeResponse FundTypeGetId(FundTypeRequest request)
        {
            FundTypeDataAccess dataAccess = new FundTypeDataAccess();

            return dataAccess.FundTypeGetId(request);
        }
        public FundTypeResponse FundTypeAdd(FundTypeRequest request)
        {
            FundTypeDataAccess dataAccess = new FundTypeDataAccess();

            return dataAccess.FundTypeAdd(request);
        }
        public FundTypeResponse FundTypeUpdate(FundTypeRequest request)
        {
            FundTypeDataAccess dataAccess = new FundTypeDataAccess();

            return dataAccess.FundTypeUpdate(request);
        }
        public FundTypeResponse FundTypeDelete(FundTypeRequest request)
        {
            FundTypeDataAccess dataAccess = new FundTypeDataAccess();

            return dataAccess.FundTypeDelete(request);
        }
    }
}
