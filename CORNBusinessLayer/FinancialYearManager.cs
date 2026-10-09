using CORNDataAccessLayer.Request;
using CORNDataAccessLayer.Response;
using CORNDatabaseLayer;

namespace CORNBusinessLayer
{
    public class FinancialYearManager
    {
        public FinancialYearResponse FinancialYearGetSchemeId(FinancialYearRequest request)
        {
            FinancialYearDataAccess dataAccess = new FinancialYearDataAccess();

            return dataAccess.FinancialYearGetSchemeId(request);
        }
        public FinancialYearResponse FinancialYearGetAll()
        {
            FinancialYearDataAccess dataAccess = new FinancialYearDataAccess();

            return dataAccess.FinancialYearGetAll();
        }
        public FinancialYearResponse FinancialYearGetId(FinancialYearRequest request)
        {
            FinancialYearDataAccess dataAccess = new FinancialYearDataAccess();

            return dataAccess.FinancialYearGetId(request);
        }
        public FinancialYearResponse FinancialYearAdd(FinancialYearRequest request)
        {
            FinancialYearDataAccess dataAccess = new FinancialYearDataAccess();

            return dataAccess.FinancialYearAdd(request);
        }
        public FinancialYearResponse FinancialYearUpdate(FinancialYearRequest request)
        {
            FinancialYearDataAccess dataAccess = new FinancialYearDataAccess();

            return dataAccess.FinancialYearUpdate(request);
        }
        public FinancialYearResponse FinancialYearDelete(FinancialYearRequest request)
        {
            FinancialYearDataAccess dataAccess = new FinancialYearDataAccess();

            return dataAccess.FinancialYearDelete(request);
        }
    }
}
