using CORNDataAccessLayer.Response;
using CORNDatabaseLayer;

namespace CORNBusinessLayer
{
    public class SchemePOReferenceNoManager
    {
        public SchemePOReferenceNoResponse SchemeExpenseBookingGetAll()
        {
            SchemePOReferenceNoDataAccess dataAccess = new SchemePOReferenceNoDataAccess();

            return dataAccess.SchemePOReferenceNoGetAll();
        }
    }
}
