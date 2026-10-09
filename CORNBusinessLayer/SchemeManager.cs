using CORNDataAccessLayer.Request;
using CORNDataAccessLayer.Response;
using CORNDatabaseLayer;

namespace CORNBusinessLayer
{
    public class SchemeManager
    {
        public SchemeResponse SchemeGetAll(SchemeRequest request)
        {
            SchemeDataAccess dataAccess = new SchemeDataAccess();

            return dataAccess.SchemeGetAll(request);
        }
        public SchemeResponse SchemeGetId(SchemeRequest request)
        {
            SchemeDataAccess dataAccess = new SchemeDataAccess();

            return dataAccess.SchemeGetId(request);
        }
        public SchemeResponse SchemeAdd(SchemeRequest request)
        {
            SchemeDataAccess dataAccess = new SchemeDataAccess();

            return dataAccess.SchemeAdd(request);
        }
        public SchemeResponse SchemeUpdate(SchemeRequest request)
        {
            SchemeDataAccess dataAccess = new SchemeDataAccess();

            return dataAccess.SchemeUpdate(request);
        }
        public SchemeResponse SchemeUpdateStatus(SchemeRequest request)
        {
            SchemeDataAccess dataAccess = new SchemeDataAccess();

            return dataAccess.SchemeUpdateStatus(request);
        }
        public SchemeResponse SchemeUpdateActiveInActive(SchemeRequest request)
        {
            SchemeDataAccess dataAccess = new SchemeDataAccess();

            return dataAccess.SchemeUpdateActiveInActive(request);
        }
        public SchemeResponse SchemeUpdatePromote(SchemeRequest request)
        {
            SchemeDataAccess dataAccess = new SchemeDataAccess();

            return dataAccess.SchemeUpdatePromote(request);
        }
    }
}
