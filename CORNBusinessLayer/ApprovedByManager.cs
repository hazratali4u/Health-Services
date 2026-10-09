using CORNDataAccessLayer.Request;
using CORNDataAccessLayer.Response;
using CORNDatabaseLayer;

namespace CORNBusinessLayer
{
    public class ApprovedByManager
    {
        public ApprovedByResponse ApprovedByGetAll()
        {
            ApprovedByDataAccess dataAccess = new ApprovedByDataAccess();

            return dataAccess.ApprovedByGetAll();
        }
        public ApprovedByResponse ApprovedByGetId(ApprovedByRequest request)
        {
            ApprovedByDataAccess dataAccess = new ApprovedByDataAccess();

            return dataAccess.ApprovedByGetId(request);
        }
        public ApprovedByResponse ApprovedByAdd(ApprovedByRequest request)
        {
            ApprovedByDataAccess dataAccess = new ApprovedByDataAccess();

            return dataAccess.ApprovedByAdd(request);
        }
        public ApprovedByResponse ApprovedByUpdate(ApprovedByRequest request)
        {
            ApprovedByDataAccess dataAccess = new ApprovedByDataAccess();

            return dataAccess.ApprovedByUpdate(request);
        }
        public ApprovedByResponse ApprovedByDelete(ApprovedByRequest request)
        {
            ApprovedByDataAccess dataAccess = new ApprovedByDataAccess();

            return dataAccess.ApprovedByDelete(request);
        }
    }
}
