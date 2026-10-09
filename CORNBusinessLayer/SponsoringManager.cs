using CORNDataAccessLayer.Request;
using CORNDataAccessLayer.Response;
using CORNDatabaseLayer;

namespace CORNBusinessLayer
{
    public class SponsoringManager
    {
        public SponsoringResponse SponsoringGetAll()
        {
            SponsoringDataAccess dataAccess = new SponsoringDataAccess();

            return dataAccess.SponsoringGetAll();
        }
        public SponsoringResponse SponsoringGetId(SponsoringRequest request)
        {
            SponsoringDataAccess dataAccess = new SponsoringDataAccess();

            return dataAccess.SponsoringGetId(request);
        }
        public SponsoringResponse SponsoringAdd(SponsoringRequest request)
        {
            SponsoringDataAccess dataAccess = new SponsoringDataAccess();

            return dataAccess.SponsoringAdd(request);
        }
        public SponsoringResponse SponsoringUpdate(SponsoringRequest request)
        {
            SponsoringDataAccess dataAccess = new SponsoringDataAccess();

            return dataAccess.SponsoringUpdate(request);
        }
        public SponsoringResponse SponsoringDelete(SponsoringRequest request)
        {
            SponsoringDataAccess dataAccess = new SponsoringDataAccess();

            return dataAccess.SponsoringDelete(request);
        }
    }
}
