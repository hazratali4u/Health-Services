using CORNDataAccessLayer.Request;
using CORNDataAccessLayer.Response;
using CORNDatabaseLayer;

namespace CORNBusinessLayer
{
    public class PC1SchemeFundApprovalManager
    {
        public SchemeFundApprovalResponse SchemeFundApprovalGetAll(SchemeFundApprovalRequest request)
        {
            PC1SchemeFundApprovalDataAccess dataAccess = new PC1SchemeFundApprovalDataAccess();

            return dataAccess.SchemeFundApprovalGetAll(request);
        }
        public SchemeFundApprovalResponse SchemeFundApprovalGetId(SchemeFundApprovalRequest request)
        {
            PC1SchemeFundApprovalDataAccess dataAccess = new PC1SchemeFundApprovalDataAccess();

            return dataAccess.SchemeFundApprovalGetId(request);
        }
        public SchemeFundApprovalResponse SchemeFundApprovalAdd(SchemeFundApprovalRequest request)
        {
            PC1SchemeFundApprovalDataAccess dataAccess = new PC1SchemeFundApprovalDataAccess();

            return dataAccess.SchemeFundApprovalAdd(request);
        }
        public SchemeFundApprovalResponse SchemeFundApprovalUpdate(SchemeFundApprovalRequest request)
        {
            PC1SchemeFundApprovalDataAccess dataAccess = new PC1SchemeFundApprovalDataAccess();

            return dataAccess.SchemeFundApprovalUpdate(request);
        }
        public SchemeFundApprovalResponse SchemeFundProposedGetSchemeId(SchemeFundApprovalRequest request)
        {
            PC1SchemeFundApprovalDataAccess dataAccess = new PC1SchemeFundApprovalDataAccess();

            return dataAccess.SchemeFundProposedGetSchemeId(request);
        }
    }
}
