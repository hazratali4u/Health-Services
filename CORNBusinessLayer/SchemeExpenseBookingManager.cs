using CORNDataAccessLayer.Request;
using CORNDataAccessLayer.Response;
using CORNDatabaseLayer;

namespace CORNBusinessLayer
{
    public class SchemeExpenseBookingManager
    {
        public SchemeExpenseBookingResponse SchemeExpenseBookingGetAll(SchemeExpenseBookingRequest request)
        {
            SchemeExpenseBookingDataAccess dataAccess = new SchemeExpenseBookingDataAccess();

            return dataAccess.SchemeExpenseBookingGetAll(request);
        }
        public SchemeExpenseBookingResponse SchemeExpenseBookingGetId(SchemeExpenseBookingRequest request)
        {
            SchemeExpenseBookingDataAccess dataAccess = new SchemeExpenseBookingDataAccess();

            return dataAccess.SchemeExpenseBookingGetId(request);
        }
        public SchemeExpenseBookingResponse SchemeExpenseBookingAdd(SchemeExpenseBookingRequest request)
        {
            SchemeExpenseBookingDataAccess dataAccess = new SchemeExpenseBookingDataAccess();

            return dataAccess.SchemeExpenseBookingAdd(request);
        }
        public SchemeExpenseBookingResponse SchemeExpenseBookingUpdate(SchemeExpenseBookingRequest request)
        {
            SchemeExpenseBookingDataAccess dataAccess = new SchemeExpenseBookingDataAccess();

            return dataAccess.SchemeExpenseBookingUpdate(request);
        }
        public SchemeExpenseBookingResponse SchemeExpenseBookingDelete(SchemeExpenseBookingRequest request)
        {
            SchemeExpenseBookingDataAccess dataAccess = new SchemeExpenseBookingDataAccess();

            return dataAccess.SchemeExpenseBookingDelete(request);
        }
        public SchemeExpenseBookingResponse SchemeFundReleaseGetSchemeId(SchemeExpenseBookingRequest request)
        {
            SchemeExpenseBookingDataAccess dataAccess = new SchemeExpenseBookingDataAccess();

            return dataAccess.SchemeFundReleaseGetSchemeId(request);
        }
        public SchemeExpenseBookingResponse SchemeExpenseBookingPayeeGet(SchemeExpenseBookingRequest request)
        {
            SchemeExpenseBookingDataAccess dataAccess = new SchemeExpenseBookingDataAccess();

            return dataAccess.SchemeExpenseBookingPayeeGet(request);
        }
    }
}
