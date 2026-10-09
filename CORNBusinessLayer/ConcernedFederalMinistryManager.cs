using CORNDataAccessLayer.Request;
using CORNDataAccessLayer.Response;
using CORNDatabaseLayer;

namespace CORNBusinessLayer
{
    public class ConcernedFederalMinistryManager
    {
        public ConcernedFederalMinistryResponse ConcernedFederalMinistryGetAll()
        {
            ConcernedFederalMinistryDataAccess dataAccess = new ConcernedFederalMinistryDataAccess();

            return dataAccess.ConcernedFederalMinistryGetAll();
        }
        public ConcernedFederalMinistryResponse ConcernedFederalMinistryGetId(ConcernedFederalMinistryRequest request)
        {
            ConcernedFederalMinistryDataAccess dataAccess = new ConcernedFederalMinistryDataAccess();

            return dataAccess.ConcernedFederalMinistryGetId(request);
        }
        public ConcernedFederalMinistryResponse ConcernedFederalMinistryAdd(ConcernedFederalMinistryRequest request)
        {
            ConcernedFederalMinistryDataAccess dataAccess = new ConcernedFederalMinistryDataAccess();

            return dataAccess.ConcernedFederalMinistryAdd(request);
        }
        public ConcernedFederalMinistryResponse ConcernedFederalMinistryUpdate(ConcernedFederalMinistryRequest request)
        {
            ConcernedFederalMinistryDataAccess dataAccess = new ConcernedFederalMinistryDataAccess();

            return dataAccess.ConcernedFederalMinistryUpdate(request);
        }
        public ConcernedFederalMinistryResponse ConcernedFederalMinistryDelete(ConcernedFederalMinistryRequest request)
        {
            ConcernedFederalMinistryDataAccess dataAccess = new ConcernedFederalMinistryDataAccess();

            return dataAccess.ConcernedFederalMinistryDelete(request);
        }
    }
}
