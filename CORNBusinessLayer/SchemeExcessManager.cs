using CORNDataAccessLayer.Request;
using CORNDataAccessLayer.Response;
using CORNDatabaseLayer;

namespace CORNBusinessLayer
{
    public class SchemeExcessManager
    {
        public SchemeExcessResponse SchemeExcessGetAll(SchemeExcessRequest request)
        {
            SchemeExcessDataAccess dataAccess = new SchemeExcessDataAccess();

            return dataAccess.SchemeExcessGetAll(request);
        }
        public SchemeExcessResponse SchemeExcessGetId(SchemeExcessRequest request)
        {
            SchemeExcessDataAccess dataAccess = new SchemeExcessDataAccess();

            return dataAccess.SchemeExcessGetId(request);
        }
        public SchemeExcessResponse SchemeExcessAdd(SchemeExcessRequest request)
        {
            SchemeExcessDataAccess dataAccess = new SchemeExcessDataAccess();

            return dataAccess.SchemeExcessAdd(request);
        }
        public SchemeExcessResponse SchemeExcessUpdate(SchemeExcessRequest request)
        {
            SchemeExcessDataAccess dataAccess = new SchemeExcessDataAccess();

            return dataAccess.SchemeExcessUpdate(request);
        }
    }
}
