using CORNDataAccessLayer.Request;
using CORNDataAccessLayer.Response;
using CORNDatabaseLayer;

namespace CORNBusinessLayer
{
    public class SchemeFundApprovalManager
    {
        public SchemeFundApprovalResponse SchemeFundApprovalGetAll(SchemeFundApprovalRequest request)
        {
            SchemeFundApprovalDataAccess dataAccess = new SchemeFundApprovalDataAccess();

            return dataAccess.SchemeFundApprovalGetAll(request);
        }
        public SchemeFundApprovalResponse SchemeFundApprovalGetId(SchemeFundApprovalRequest request)
        {
            SchemeFundApprovalDataAccess dataAccess = new SchemeFundApprovalDataAccess();

            return dataAccess.SchemeFundApprovalGetId(request);
        }
        public SchemeFundApprovalResponse SchemeFundApprovalAdd(SchemeFundApprovalRequest request)
        {
            SchemeFundApprovalDataAccess dataAccess = new SchemeFundApprovalDataAccess();

            return dataAccess.SchemeFundApprovalAdd(request);
        }
        public SchemeFundApprovalResponse SchemeFundApprovalUpdate(SchemeFundApprovalRequest request)
        {
            SchemeFundApprovalDataAccess dataAccess = new SchemeFundApprovalDataAccess();

            return dataAccess.SchemeFundApprovalUpdate(request);
        }
        public SchemeFundApprovalResponse SchemeFundProposedGetSchemeId(SchemeFundApprovalRequest request)
        {
            SchemeFundApprovalDataAccess dataAccess = new SchemeFundApprovalDataAccess();

            return dataAccess.SchemeFundProposedGetSchemeId(request);
        }
    }
}
