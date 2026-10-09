using CORNDataAccessLayer.Request;
using CORNDataAccessLayer.Response;
using CORNDatabaseLayer;

namespace CORNBusinessLayer
{
    public class SchemeFundReleaseManager
    {
        public SchemeFundReleaseResponse SchemeFundReleaseGetAll(SchemeFundReleaseRequest request)
        {
            SchemeFundReleaseDataAccess dataAccess = new SchemeFundReleaseDataAccess();

            return dataAccess.SchemeFundReleaseGetAll(request);
        }
        public SchemeFundReleaseResponse SchemeFundReleaseGetId(SchemeFundReleaseRequest request)
        {
            SchemeFundReleaseDataAccess dataAccess = new SchemeFundReleaseDataAccess();

            return dataAccess.SchemeFundReleaseGetId(request);
        }
        public SchemeFundReleaseResponse SchemeFundReleaseAdd(SchemeFundReleaseRequest request)
        {
            SchemeFundReleaseDataAccess dataAccess = new SchemeFundReleaseDataAccess();

            return dataAccess.SchemeFundReleaseAdd(request);
        }
        public SchemeFundReleaseResponse SchemeFundReleaseUpdate(SchemeFundReleaseRequest request)
        {
            SchemeFundReleaseDataAccess dataAccess = new SchemeFundReleaseDataAccess();

            return dataAccess.SchemeFundReleaseUpdate(request);
        }
        public SchemeFundReleaseResponse SchemeFundAllocationGetSchemeId(SchemeFundReleaseRequest request)
        {
            SchemeFundReleaseDataAccess dataAccess = new SchemeFundReleaseDataAccess();

            return dataAccess.SchemeFundAllocationGetSchemeId(request);
        }
        public SchemeFundReleaseResponse SchemeFundAllocationGetSchemeIdForTotal(SchemeFundReleaseRequest request)
        {
            SchemeFundReleaseDataAccess dataAccess = new SchemeFundReleaseDataAccess();

            return dataAccess.SchemeFundAllocationGetSchemeIdForTotal(request);
        }
    }
}
