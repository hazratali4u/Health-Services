using CORNDataAccessLayer.Request;
using CORNDataAccessLayer.Response;
using CORNDatabaseLayer;

namespace CORNBusinessLayer
{
    public class SchemeFundProposalManager
    {
        public SchemeFundProposalResponse SchemeFundProposalGetAll(SchemeFundProposalRequest request)
        {
            SchemeFundProposalDataAccess dataAccess = new SchemeFundProposalDataAccess();

            return dataAccess.SchemeFundProposalGetAll(request);
        }
        public SchemeFundProposalResponse SchemeFundProposalGetId(SchemeFundProposalRequest request)
        {
            SchemeFundProposalDataAccess dataAccess = new SchemeFundProposalDataAccess();

            return dataAccess.SchemeFundProposalGetId(request);
        }
        public SchemeFundProposalResponse SchemeFundProposalAdd(SchemeFundProposalRequest request)
        {
            SchemeFundProposalDataAccess dataAccess = new SchemeFundProposalDataAccess();

            return dataAccess.SchemeFundProposalAdd(request);
        }
        public SchemeFundProposalResponse SchemeFundProposalUpdate(SchemeFundProposalRequest request)
        {
            SchemeFundProposalDataAccess dataAccess = new SchemeFundProposalDataAccess();

            return dataAccess.SchemeFundProposalUpdate(request);
        }
    }
}
