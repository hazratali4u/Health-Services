using CORNDataAccessLayer.Request;
using CORNDataAccessLayer.Response;
using CORNDatabaseLayer;

namespace CORNBusinessLayer
{
    public class SchemeFundAllocationManager
    {
        public SchemeFundAllocationResponse SchemeFundAllocationGetAll(SchemeFundAllocationRequest request)
        {
            SchemeFundAllocationDataAccess dataAccess = new SchemeFundAllocationDataAccess();

            return dataAccess.SchemeFundAllocationGetAll(request);
        }
        public SchemeFundAllocationResponse SchemeFundAllocationGetId(SchemeFundAllocationRequest request)
        {
            SchemeFundAllocationDataAccess dataAccess = new SchemeFundAllocationDataAccess();

            return dataAccess.SchemeFundAllocationGetId(request);
        }
        public SchemeFundAllocationResponse SchemeFundAllocationAdd(SchemeFundAllocationRequest request)
        {
            SchemeFundAllocationDataAccess dataAccess = new SchemeFundAllocationDataAccess();

            return dataAccess.SchemeFundAllocationAdd(request);
        }
        public SchemeFundAllocationResponse SchemeFundAllocationUpdate(SchemeFundAllocationRequest request)
        {
            SchemeFundAllocationDataAccess dataAccess = new SchemeFundAllocationDataAccess();

            return dataAccess.SchemeFundAllocationUpdate(request);
        }
        public SchemeFundAllocationResponse SchemeFundApprovalGetSchemeId(SchemeFundAllocationRequest request)
        {
            SchemeFundAllocationDataAccess dataAccess = new SchemeFundAllocationDataAccess();

            return dataAccess.SchemeFundApprovalGetSchemeId(request);
        }
    }
}
